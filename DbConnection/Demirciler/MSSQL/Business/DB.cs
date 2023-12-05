
using DbConnection.Data.MSSQL.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace Projects.DbConnection.Business.MSSQL
{
	public class Database : IDisposable
	{
		private SqlConnection cn;

		public Database(string connectionString)
		{
			cn = new SqlConnection();
			cn.ConnectionString = connectionString;
			cn.Open();
		}

		public static object DBNulltoNull(object o)
		{
			return o == DBNull.Value ? null : o;
		}

		public static DateTime mindate = new DateTime(1900, 1, 1), maxdate = new DateTime(2100, 1, 1);

		public static string SqlDate(DateTime date)
		{
			return string.Format($@"{0:yyyy-MM-dd HH:mm:ss}", date < mindate ? mindate : (date > maxdate ? maxdate : date));
		}

		public DataTable GetSchema(string tablename)
		{
			var cmd = CreateCommand("select top 1 * from " + tablename);
			using (var reader = cmd.ExecuteReader())
			{
				return reader.GetSchemaTable();
			}
		}

		public void Execute(System.IO.StreamReader sr)
		{
			var sb = new StringBuilder();
			string line;
			while ((line = sr.ReadLine()) != null)
			{
				if (line.ToUpper().Trim() == "GO")
				{
					if (sb.Length > 0)
						ExecuteNonQuery(sb.ToString());
					sb.Clear();
				}
				else
					sb.AppendLine(line);
			}
			if (sb.Length > 0)
				ExecuteNonQuery(sb.ToString());
		}

		public int ExecuteNonQuery(string txt, params object[] parameters)
		{
			return CreateCommand(txt, parameters).ExecuteNonQuery();
		}

		public T ExecuteScaler<T>(string txt, params object[] parameters)
		{
			var ret = CreateCommand(txt, parameters).ExecuteScalar();
			return ret == DBNull.Value ? default(T) : (T) ret;
		}

		public int ExecuteNonQuery<T>(string txt, params object[] parameters)
		{
			var ret = CreateCommand(txt, parameters).ExecuteNonQuery();
			return ret;
		}

		public IEnumerable<T> ExecuteReader<T>(string txt, params object[] parameters) where T : new()
		{
			var cmd = CreateCommand(txt, parameters);
			if (cmd.Connection.State != ConnectionState.Open)
				cmd.Connection.Open();

			using (var reader = cmd.ExecuteReader())
			{
				var t = typeof(T);
				Action<object, object>[] setters = new Action<object, object>[reader.FieldCount];
				for (int i = 0; i < reader.FieldCount; i++)
				{
					setters[i] = PropertyAccessGenerator.SetDelegate(t, reader.GetName(i));
				}
				while (reader.Read())
				{
					T ret = new T();
					for (int i = 0; i < reader.FieldCount; i++)
					{
						var column = reader.GetName(i);
						if (setters[i] != null && !(reader.GetValue(i) is DBNull) && reader.GetValue(i) != null)
							setters[i](ret, reader.GetValue(i));
					}
					yield return ret;
				}
			}
		}

		public IEnumerable<T> ExecuteSearch<T>(T parametre) where T : new()
		{
			List<_Param> param = new List<_Param>();
			List<object> paramObjects = new List<object>();

			var sql = string.Format("Select * From {0} Where ", parametre.GetType().Name);
			int ki = 0;

			foreach (var p in parametre.GetType().GetProperties().Where(p => p.GetValue(parametre, null) != null))
			{
				if (p.Name == "Intid") continue;
				if (string.IsNullOrEmpty(p.GetValue(parametre, null).ToString().Trim())) continue;

				if (ki == 0)
					sql += string.Format(" ");
				else
					sql += string.Format(" and");

				if (p.PropertyType == typeof(string))
				{
					sql += string.Format(" {0} Like {1}", p.Name, "{" + ki + "}");
					paramObjects.Add("%" + p.GetValue(parametre, null) + "%");
				}
				else
				{
					sql += string.Format(" {0} = {1} ", p.Name, "{" + ki + "}");
					paramObjects.Add(p.GetValue(parametre, null));
				}

				ki++;
			}

			if (ki == 0)
				sql = sql.Replace("Where", "");

			var cmd = CreateCommand(sql, paramObjects.ToArray());
			if (cmd.Connection.State != ConnectionState.Open)
				cmd.Connection.Open();

			using (var reader = cmd.ExecuteReader())
			{
				var t = typeof(T);
				Action<object, object>[] setters = new Action<object, object>[reader.FieldCount];
				for (int i = 0; i < reader.FieldCount; i++)
				{
					setters[i] = PropertyAccessGenerator.SetDelegate(t, reader.GetName(i));
				}
				while (reader.Read())
				{
					T ret = new T();
					for (int i = 0; i < reader.FieldCount; i++)
					{
						if (setters[i] != null && !(reader.GetValue(i) is DBNull) && reader.GetValue(i) != null)
							setters[i](ret, reader.GetValue(i));
					}
					yield return ret;
				}
			}
		}

		public int ExecuteSearchCount<T>(T parametre) where T : new()
		{
			List<_Param> param = new List<_Param>();
			List<object> paramObjects = new List<object>();

			var sql = string.Format("Select Count(Intid) From {0} Where ", parametre.GetType().Name);
			int ki = 0;

			foreach (var p in parametre.GetType().GetProperties().Where(p => p.GetValue(parametre, null) != null))
			{
				if (p.Name == "Intid") continue;
				if (string.IsNullOrEmpty(p.GetValue(parametre, null).ToString().Trim())) continue;

				if (ki == 0)
					sql += string.Format(" ");
				else
					sql += string.Format(" and");

				if (p.PropertyType == typeof(string))
				{
					sql += string.Format(" {0} Like {1}", p.Name, "{" + ki + "}");
					paramObjects.Add("%" + p.GetValue(parametre, null) + "%");
				}
				else
				{
					sql += string.Format(" {0} = {1} ", p.Name, "{" + ki + "}");
					paramObjects.Add(p.GetValue(parametre, null));
				}

				ki++;
			}

			if (ki == 0)
				sql = sql.Replace("Where", "");

			return ExecuteScaler<int>(sql, paramObjects.ToArray());
		}

		public ResultObject<T> ExecuteSearchPageList<T>(T parametre, PageProperties pageProperties) where T : new()
		{
			pageProperties.PageNumber -= 1;

			List<_Param> param = new List<_Param>();
			List<object> paramObjects = new List<object>();

			var whereSql = "";
			int ki = 0;
			foreach (var p in parametre.GetType().GetProperties().Where(p => p.GetValue(parametre, null) != null))
			{
				if (p.Name == "Intid") continue;
				if (string.IsNullOrEmpty(p.GetValue(parametre, null).ToString().Trim())) continue;

				if (ki == 0)
					whereSql += string.Format(" Where");
				else
					whereSql += string.Format(" and");
				if (p.PropertyType == typeof(string))
				{
					whereSql += string.Format(" {0} Like {1}", p.Name, "'%" + p.GetValue(parametre, null) + "%'");
					paramObjects.Add("%" + p.GetValue(parametre, null) + "%");
				}
				else
				{
					whereSql += string.Format(" {0} = {1} ", p.Name, p.GetValue(parametre, null));
					paramObjects.Add(p.GetValue(parametre, null));
				}

				ki++;
			}

			var sql = string.Format("SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY {4} {5}) AS RowNum FROM {0} {6}) AS DerivedTable WHERE DerivedTable.RowNum BETWEEN {3} AND {1} * {2} + {2}", parametre.GetType().Name, pageProperties.PageNumber, pageProperties.PageSize, pageProperties.PageNumber * pageProperties.PageSize + 1, pageProperties.Sort, pageProperties.SortType, whereSql);

			return new ResultObject<T>
			{
				Object = ExecuteReader<T>(sql, paramObjects.ToArray()).ToArray(),
				Count = ExecuteSearchCount<T>(parametre)
			};
		}

		public SqlCommand PrepareCommand(string sql, _Param[] parameters)
		{
			var cmd = cn.CreateCommand();
			cmd.CommandText = sql;
			foreach (var item in parameters)
			{
				cmd.Parameters.AddWithValue(item.name, item.value);
			}
			return cmd;
		}

		public SqlCommand CreateCommand(string txt, params object[] parameters)
		{
			var cmd = cn.CreateCommand();
            cmd.CommandTimeout = 60 * 5;
			cmd.CommandType = txt.IndexOf(' ') == -1 ? CommandType.StoredProcedure : CommandType.Text;
			if (cmd.CommandType == CommandType.StoredProcedure)
			{
				cmd.CommandText = txt;
				SqlCommandBuilder.DeriveParameters(cmd);
				for (int i = 1; i < cmd.Parameters.Count; i++)
				{
					if (i - 1 < parameters.Length)
					{
						cmd.Parameters[i].Value = parameters[i - 1] ?? DBNull.Value;
					}
				}
			}
			else
			{
				for (int i = 0; i < parameters.Length; i++)
				{
					var p = cmd.CreateParameter();

					p.ParameterName = "@p" + i.ToString();
					p.Value = parameters[i] ?? DBNull.Value;
					cmd.Parameters.Add(p);
				}
				if (cmd.Parameters.Count > 0)
				{
					cmd.CommandText = string.Format(txt, cmd.Parameters.Cast<SqlParameter>().Select(a => a.ParameterName).ToArray());
				}
				else
				{
					cmd.CommandText = txt;
				}
			}
			return cmd;
		}

		public IEnumerable<object[]> ExecuteReader(string txt, params object[] parameters)
		{
			var cmd = CreateCommand(txt, parameters);

			using (var reader = cmd.ExecuteReader())
			{
				while (reader.Read())
				{
					object[] ret = new object[reader.FieldCount];
					for (int i = 0; i < reader.FieldCount; i++)
					{
						ret[i] = reader.GetValue(i);
					}
					yield return ret;
				}
			}
		}

		public ResultStatus ExecuteInsert<T>(T parametre)
		{
			string parametrename = "";
			string parametrevalue = "";
			List<_Param> param = new List<_Param>();
			foreach (var p in parametre.GetType().GetProperties().Where(p => p.GetValue(parametre, null) != null))
			{
				if (string.IsNullOrEmpty(p.GetValue(parametre, null).ToString().Trim())) continue;
				if (new string[] { "intId", "intid", "IntId", "Intid" }.Contains(p.Name)) continue;
				//if (p.Name == "id") continue;
				parametrename += "," + p.Name;
				parametrevalue += ",@" + p.Name;
				param.Add(new _Param { name = "@" + p.Name, value = p.GetValue(parametre, null) });
			}
			parametrename = parametrename.Substring(1);
			parametrevalue = parametrevalue.Substring(1);
			if (parametrename.Length > 2)
			{
				var sql = string.Format("Insert Into {0} ({1}) values({2}) ", parametre.GetType().Name, parametrename, parametrevalue);
				try
				{
					var tr = PrepareCommand(sql, param.ToArray()).ExecuteNonQuery();
					return new ResultStatus
					{
						message = tr.ToString(),
						result = true
					};
				}
				catch (Exception ex)
				{
					return new ResultStatus
					{
						message = "UnSuccessfull - " + ex.ToString(),
						result = false
					};
				}
			}
			return new ResultStatus
			{
				message = "UnSuccessfull",
				result = false
			};
		}

		public DataTable ExecuteAdapter(string txt, params object[] parameters)
		{
			var cmd = CreateCommand(txt, parameters);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			return dt;
		}

		public ResultStatus ExecuteUpdate<T>(T parametre, string id)
		{
			string parametrename = "";
			List<_Param> param = new List<_Param>();
			foreach (var p in parametre.GetType().GetProperties().Where(p => p.GetValue(parametre, null) != null))
			{
				if (string.IsNullOrEmpty(p.GetValue(parametre, null).ToString().Trim())) continue;
				if (p.Name == "Intid") continue;
				if (p.Name == "id") continue;
				parametrename += "," + p.Name + "=@" + p.Name;
				param.Add(new _Param { name = "@" + p.Name, value = p.GetValue(parametre, null) });
			}
			parametrename = parametrename.Substring(1);

			if (parametrename.Length > 2)
			{
				var sql = string.Format("Update {0} Set {1} where id = '{2}' ", parametre.GetType().Name, parametrename, id);
				try
				{
					var tr = PrepareCommand(sql, param.ToArray()).ExecuteNonQuery();
					return new ResultStatus
					{
						message = tr.ToString(),
						result = true
					};
				}
				catch (Exception ex)
				{
					return new ResultStatus
					{
						message = "UnSuccessfull - " + ex.ToString(),
						result = false
					};
				}
			}
			return new ResultStatus
			{
				message = "UnSuccessfull",
				result = false
			};
		}

		public ResultStatus ExecuteUpdate<T>(T parametre)
		{
			string id = "";
			string parametrename = "";
			List<_Param> param = new List<_Param>();
			foreach (var p in parametre.GetType().GetProperties().Where(p => p.GetValue(parametre, null) != null))
			{
				if (string.IsNullOrEmpty(p.GetValue(parametre, null).ToString().Trim())) continue;
				if (p.Name == "id")
				{
					id = p.GetValue(parametre, null).ToString();
				}
				if (p.Name == "Intid")
				{
					continue;
				}
				else
				{
					parametrename += "," + p.Name + "=@" + p.Name;
					param.Add(new _Param { name = "@" + p.Name, value = p.GetValue(parametre, null) });
				}
			}
			parametrename = parametrename.Substring(1);

			if (parametrename.Length > 2)
			{
				var sql = string.Format("Update {0} Set {1} where id = '{2}' ", parametre.GetType().Name, parametrename, id);
				try
				{
					var tr = PrepareCommand(sql, param.ToArray()).ExecuteNonQuery();
					return new ResultStatus
					{
						message = tr.ToString(),
						result = true
					};
				}
				catch (Exception ex)
				{
					return new ResultStatus
					{
						message = "UnSuccessfull - " + ex.ToString(),
						result = false
					};
				}
			}
			return new ResultStatus
			{
				message = "UnSuccessfull",
				result = false
			};
		}

		public ResultStatus ExecuteDelete<T>(T parametre)
		{
			string id = "";
			List<_Param> param = new List<_Param>();
			foreach (var p in parametre.GetType().GetProperties().Where(p => p.GetValue(parametre, null) != null))
			{
				if (string.IsNullOrEmpty(p.GetValue(parametre, null).ToString().Trim())) continue;
				if (p.Name == "id")
				{
					id = p.GetValue(parametre, null).ToString();
				}
			}

			var sql = string.Format("delete  from {0} where id = '{1}' ", parametre.GetType().Name, id);
			try
			{
				var tr = PrepareCommand(sql, param.ToArray()).ExecuteNonQuery();
				return new ResultStatus
				{
					message = tr.ToString(),
					result = true
				};
			}
			catch (Exception ex)
			{
				return new ResultStatus
				{
					message = "UnSuccessfull - " + ex.ToString(),
					result = false
				};
			}
		}

		public bool ClassHaveItem<T>(T parametre, string Item)
		{
			return parametre.ToString().Contains(Item) ? true : false;
		}

		public string CreateTable<T>()
		{
			var t = typeof(T);

			this.ExecuteNonQuery(string.Format(@"IF  not (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{1}_Values' ) )
BEGIN
CREATE TABLE [dbo].[{1}_Values](
	[istasyon] [int] NOT NULL,
	[tarih] [datetime] NOT NULL,
	[scr] [tinyint] not null,
	{0}
 CONSTRAINT [PK_{1}_Values] PRIMARY KEY CLUSTERED
(
	[istasyon] ASC,
	[tarih] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END",
			   string.Join(",", t.GetFields().Select(a => string.Format(" [{0}] [{1}] not null", a.Name, a.FieldType == typeof(byte) ? "tinyint" : "smallint"))),
			   t.Name
			   ));
			return t.Name + "_Values";
		}

		public void Dispose()
		{
			cn.Close();
			cn.Dispose();
			cn = null;
		}

		//      YENİ        //

		public ResultStatus ExecuteBulkUpdate<T>(List<T> parametre, Expression<Func<T, object>> idexp, Expression<Func<T, object>> exceprexp = null, string tableName = null)
		{
			try
			{
				if (tableName == null)
					tableName = typeof(T).Name;
				var except = ExpressionHelper.GetPropertyNames<T, object>(exceprexp).ToArray();
				var idprop = (PropertyInfo) ExpressionHelper.GetProperty<T, object>(idexp);

				using (var cmd = cn.CreateCommand())
				{
					var pSayi = 0;
					foreach (var prm in parametre)
					{
						object id = null;
						var parametrename = "";
						foreach (var p in prm.GetType().GetProperties()
							.Where(p => p.GetValue(prm, null) != null)
							.Where(p => !string.IsNullOrEmpty(p.GetValue(prm, null).
								ToString().Trim())).Where(p => !except.Contains(p.Name)))
						{
							pSayi++;
							id = idprop.GetValue(prm, null);
							parametrename += "," + p.Name + "=@" + p.Name + pSayi;
							cmd.Parameters.AddWithValue("@" + p.Name + pSayi, p.GetValue(prm, null));
						}
						var firstOrDefault = parametre.FirstOrDefault();
						if (firstOrDefault != null)
							cmd.CommandText += string.Format("Update {0} Set {1} where id = '{2}' ; ", firstOrDefault.GetType().Name, parametrename.Substring(1), id);
					}

					cmd.UpdatedRowSource = UpdateRowSource.None;
					var tr = cmd.ExecuteNonQuery();
					return new ResultStatus
					{
						message = tr.ToString(),
						result = true
					};
				}
			}
			catch (Exception ex)
			{
				return new ResultStatus
				{
					message = "UnSuccessfull - " + ex.ToString(),
					result = false
				};
			}
		}

		//Todo
		public ResultStatus ExecuteBulkUpdate<T>(IEnumerable<T> parametre)
		{
			parametre = parametre.ToList();
			var result = new ResultStatus();

			if (parametre.Count() == 0)
			{
				return new ResultStatus { result = true, message = "0" };
			}

			var list = new List<T>();
			var propCount = parametre.FirstOrDefault().GetType().GetProperties().Count();
			var intParam = Convert.ToInt32(2100 / propCount);

			if (parametre.Count() < intParam)
			{
				result = BulkUpdate<T>(parametre);
			}
			else
			{
				foreach (var prm in parametre)
				{
					list.Add(prm);
					if (list.Count > intParam)
					{
						result = BulkUpdate<T>(list);
						if (result.result == false)
						{
							return result;
						}
						list.Clear();
					}
				}

				if (list.Count > 0)
					result = BulkUpdate<T>(list);
			}
			return result;
		}

		//Todo
		private ResultStatus BulkUpdate<T>(IEnumerable<T> parametre)
		{
			parametre = parametre.ToList();
			try
			{
				using (var cmd = cn.CreateCommand())
				{
					var pSayi = 0;
					foreach (var prm in parametre) // liste
					{
						var id = "";
						var parametrename = "";
						foreach (var p in prm.GetType().GetProperties()
							.Where(p => p.GetValue(prm, null) != null)
							.Where(p => !string.IsNullOrEmpty(p.GetValue(prm, null).
								ToString().Trim())).Where(p => p.Name != "Intid"))
						{
							pSayi++;
							if (p.Name == "id" || p.Name == "Id") { id = p.GetValue(prm, null).ToString(); }
							parametrename += "," + p.Name + "=@" + p.Name + pSayi;
							cmd.Parameters.AddWithValue("@" + p.Name + pSayi, p.GetValue(prm, null));
						}
						var firstOrDefault = parametre.FirstOrDefault();
						if (firstOrDefault != null)
							cmd.CommandText += string.Format("Update {0} Set {1} where id = '{2}' ; ", firstOrDefault.GetType().Name, parametrename.Substring(1), id);
					}

					cmd.UpdatedRowSource = UpdateRowSource.None;
					var tr = cmd.ExecuteNonQuery();
					return new ResultStatus
					{
						message = tr.ToString(),
						result = true
					};
				}
			}
			catch (Exception ex)
			{
				return new ResultStatus
				{
					message = "UnSuccessfull - " + ex.ToString(),
					result = false
				};
			}
		}

		public ResultStatus ExecuteBulkInsert<T>(IEnumerable<T> parametre) where T : new()
		{
			var dt = new DataTable();
			var dbTable = string.Empty;
			parametre = parametre.ToList();
			var dbObjProps = new T().GetType().GetProperties();

			foreach (var prm in parametre)
			{
				var row = dt.NewRow();

				foreach (var p in prm.GetType().GetProperties()
					.Where(p => p.GetValue(prm, null) != null)
					.Where(p => !string.IsNullOrEmpty(p.GetValue(prm, null).ToString().Trim()))
					.Where(p => p.Name.ToLowerInvariant() != "intid"))
				{
					if (!dbObjProps.Select(a => a.Name).Contains(p.Name)) { continue; }

					if (!dt.Columns.Contains(p.Name))
					{
						// Guid id EMPTY ( 00000000-0000-0000-0000-000000000000) gelir ise
						var nulliD = prm.GetType().GetProperties()
							.Where(a => a.Name.ToLowerInvariant() == "id"
							&& (a.PropertyType == typeof(Guid) || a.PropertyType == typeof(Guid?))
							&& (a.GetValue(prm, null) == null || ((Guid) a.GetValue(prm, null)) == Guid.Empty)).FirstOrDefault();

						if (nulliD != null) { nulliD.SetValue(prm, Guid.NewGuid(), null); }

						dbTable = typeof(T).Name;
						var column = DatColumn(p.GetValue(prm, null).GetType().Name, p.Name);
						dt.Columns.Add(column);
					}
					row[p.Name] = p.GetValue(prm, null).ToString();
				}
				dt.Rows.Add(row);
			}

			try
			{
				return PrepareCommand(dt, dbTable);
			}
			catch (Exception ex)
			{
				return new ResultStatus
				{
					message = "UnSuccessfull - " + ex,
					result = false
				};
			}
		}

		private DataColumn DatColumn(string type, string name)
		{
			if (type.Equals(DbType.Guid.ToString()))
				return new DataColumn(name, typeof(Guid));
			if (type.Equals(DbType.DateTime.ToString()))
				return new DataColumn(name, typeof(DateTime));
			if (type.Equals(DbType.Boolean.ToString()))
				return new DataColumn(name, typeof(Boolean));
			if (type.Equals(DbType.Int32.ToString()))
				return new DataColumn(name, typeof(Int32));
			return new DataColumn(name);
		}

		public ResultStatus PrepareCommand(DataTable dt, string dbTable)
		{
			try
			{
				using (var copy = new SqlBulkCopy(cn))
				{
					foreach (var item in dt.Columns)
					{
						copy.ColumnMappings.Add(item.ToString(), item.ToString());
					}
					copy.DestinationTableName = dbTable;
					copy.WriteToServer(dt);
					return new ResultStatus() { message = "Ok..", result = true };
				}
			}
			catch (Exception ex)
			{
				return new ResultStatus() { message = ex.Message, result = false };
			}
		}

		public ResultStatus ExecuteBulkDelete<T>(IEnumerable<T> parametre)
		{
			if (parametre.Count() == 0) return new ResultStatus { message = "parametre sayısı 0", result = true };

			string id = "";
			parametre = parametre.ToList();
			var parametreName = string.Empty;
			List<_Param> param = new List<_Param>();

			foreach (var prm in parametre)
			{
				foreach (var p in prm.GetType().GetProperties().Where(p => p.GetValue(prm, null) != null && (p.Name.Equals("id") || p.Name.Equals("Id"))))
				{
					parametreName = prm.GetType().Name;
					;
					if (string.IsNullOrEmpty(p.GetValue(prm, null).ToString().Trim())) continue;
					if (p.Name == "id" || p.Name == "Id")
					{
						id += string.Format("'{0}',", p.GetValue(prm, null));
						//= String.Format("'{0},'", String.Join("','", ));// String.Format("'{0}'", p.GetValue(prm, null).ToString());
					}
				}
			}
			id = id.TrimEnd(',');

			var sql = string.Format("DELETE {0} WHERE id  IN ({1}) ", parametreName, id);
			try
			{
				var tr = PrepareCommand(sql, param.ToArray()).ExecuteNonQuery();
				return new ResultStatus
				{
					message = tr.ToString(),
					result = true
				};
			}
			catch (Exception ex)
			{
				return new ResultStatus
				{
					message = "UnSuccessfull - " + ex.ToString(),
					result = false
				};
			}
		}
	}

	public class Cache<TKey, TValue>
	{
		private Dictionary<TKey, TValue> dic = new Dictionary<TKey, TValue>();
		public IEnumerable<TValue> Values { get { return dic.Values; } }
		public IEnumerable<TKey> Keys { get { return dic.Keys; } }
		public int Size { get; private set; }

		public Cache(int size)
		{
			Size = size;
		}

		public bool TryGet(TKey key, out TValue value)
		{
			return dic.TryGetValue(key, out value);
		}

		public void Remove(TKey key)
		{
			if (dic.ContainsKey(key))
				dic.Remove(key);
		}

		public void Add(TKey key, TValue value)
		{
			if (!dic.ContainsKey(key))
			{
				dic.Add(key, value);

				int size = dic.Count - Size;
				dic.Keys.Take(size).ToList().ForEach(a => dic.Remove(a));
			}
			else
				dic[key] = value;
		}

		public TValue Get(TKey key, Func<TValue> create)
		{
			TValue val;
			if (!dic.TryGetValue(key, out val))
			{
				val = create();
				Add(key, val);
			}
			return val;
		}
	}

	public static class PropertyAccessGenerator
	{
		private static object Cnv(object a, Type t)
		{
			if (a is string)
				return a;
			if (a is DBNull) return null;
			if (a is Int64 || a is Double)
			{
				Type nt = Nullable.GetUnderlyingType(t);
				if (nt != null) t = nt;
				return Convert.ChangeType(a, t);
			}
			return a;
		}

		private static Cache<string, Action<object, object>> _setCache = new Cache<string, Action<object, object>>(100);

		private static Cache<string, Func<object, object>> _getCache = new Cache<string, Func<object, object>>(100);

		public static Action<object, object> SetDelegate(Type type, string name)
		{
			Action<object, object> fnc;
			var key = type.FullName + name;

			if (!_setCache.TryGet(key, out fnc))
			{
				PropertyInfo pi = type.GetProperty(name);
				if (pi == null)
					return null;
				Expression<Func<object, Type, object>> convert = (a, t) => Cnv(a, t);

				ParameterExpression p = Expression.Parameter(typeof(object));
				ParameterExpression p1 = Expression.Parameter(typeof(object));
				LabelTarget rt = Expression.Label();

				LambdaExpression l = Expression.Lambda(typeof(Action<object, object>),
					Expression.Block(
					   Expression.Assign(
							Expression.Property(Expression.Convert(p, type), pi),
							Expression.Convert(
								Expression.Invoke(convert, p1, Expression.Constant(pi.PropertyType)), pi.PropertyType
							)
					   ),
					   Expression.Label(rt)
					)
				 , p, p1);
				fnc = (Action<object, object>) l.Compile();
				_setCache.Add(key, fnc);
			}
			return fnc;
		}

		public static Func<object, object> GetDelegate(Type type, string name)
		{
			Func<object, object> fnc;
			var key = type.Name + name;
			if (!_getCache.TryGet(key, out fnc))
			{
				PropertyInfo pi = type.GetProperty(name);
				if (pi == null)
					return null;
				System.Linq.Expressions.ParameterExpression p = System.Linq.Expressions.Expression.Parameter(typeof(object));

				LambdaExpression l = Expression.Lambda(typeof(Func<object, object>),
					Expression.Convert(
						Expression.Property(
							Expression.Convert(p, type), pi
						), typeof(object)
					 ), p);
				fnc = (Func<object, object>) l.Compile();
				_getCache.Add(key, fnc);
			}
			return fnc;
		}
	}

	public class _Param
	{
		public string name { get; set; }
		public object value { get; set; }
	}

	public class ParamterName : Attribute
	{
		public string Name { get; set; }

		public ParamterName(string name)
		{
			Name = name;
		}
	}

	public class ResultStatus
	{
		public bool result { get; set; }
		public string message { get; set; }
		public object objects { get; set; }
	}

	public class ResultObject<T>
	{
		public IEnumerable<T> Object { get; set; }
		public int Count { get; set; }
	}

	public class PageProperties
	{
		public int PageNumber { get; set; }
		public int PageSize { get; set; }
		public string Sort { get; set; }
		public string SortType { get; set; }
		public int PageCount { get; set; }
		public int TotalItemCount { get; set; }
		public bool IsFirstPage { get; set; }
		public bool IsLastPage { get; set; }
		public int FirstItemOnPage { get; set; }
		public int LastItemOnPage { get; set; }
		public bool HasNextPage { get; set; }
		public bool HasPrevPage { get; set; }
	}
}
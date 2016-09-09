using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Qhyhgf.Orm.Config;
namespace Qhyhgf.Orm.ExpressionEx
{
    /// <summary>
    /// sql参数解析包
    /// </summary>
	public class SqlPack
	{
        /// <summary>
        /// 数据库别名
        /// </summary>
		private static readonly List<string> S_listEnglishWords = new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
        /// <summary>
        /// 数据库名字典
        /// </summary>
		private Dictionary<string, string> _dicTableName = new Dictionary<string, string>();
		private Queue<string> _queueEnglishWords = new Queue<string>(S_listEnglishWords);
        /// <summary>
        /// 是不是单独表
        /// </summary>
		public bool IsSingleTable { get; set; }
        /// <summary>
        /// 查询的select field字段集合
        /// </summary>
		public List<string> SelectFields { get; set; }
        /// <summary>
        ///  查询的select field字符串
        /// </summary>
		public string SelectFieldsStr
		{
			get
			{
				return string.Join(",", this.SelectFields);
			}
		}
        /// <summary>
        /// sql长度
        /// </summary>
		public int Length
		{
			get
			{
				return this.Sql.Length;
			}
		}
        /// <summary>
        /// 生成的sql语句
        /// </summary>
		public StringBuilder Sql { get; set; }
        /// <summary>
        /// 数据库类型
        /// </summary>
        public DataSourceType DatabaseType { get; set; }
        /// <summary>
        /// 参数集合
        /// </summary>
		public Dictionary<string, object> DbParams { get; private set; }
        /// <summary>
        /// 数据库前缀
        /// </summary>
		private string DbParamPrefix
		{
			get
			{
                switch (this.DatabaseType)
				{
                    case DataSourceType.SqlLite:
                    case DataSourceType.SqlServer: return "@";
                    case DataSourceType.MysSql: return "?";
					case DataSourceType.Oracl: return ":";
					default: return "";
				}
			}
		}
        /// <summary>
        /// 索引
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
		public char this[int index]
		{
			get
			{
				return this.Sql[index];
			}
		}

		public SqlPack()
		{
			this.DbParams = new Dictionary<string, object>();
			this.Sql = new StringBuilder();
			this.SelectFields = new List<string>();

		}
        /// <summary>
        /// 重载+运算符
        /// </summary>
        /// <param name="sqlPack"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
		public static SqlPack operator +(SqlPack sqlPack, string sql)
		{
			sqlPack.Sql.Append(sql);
			return sqlPack;
		}
        /// <summary>
        /// 清空参数
        /// </summary>
		public void Clear()
		{
			this.SelectFields.Clear();
			this.Sql.Clear();
			this.DbParams.Clear();
			this._dicTableName.Clear();
			this._queueEnglishWords = new Queue<string>(S_listEnglishWords);
		}
        /// <summary>
        /// 添加参数
        /// </summary>
        /// <param name="parameterValue"></param>
		public void AddDbParameter(object parameterValue)
		{
			if (parameterValue == null || parameterValue == DBNull.Value)
			{
				this.Sql.Append(" null");
			}
			else
			{
				string name = this.DbParamPrefix + "param" + this.DbParams.Count;
				this.DbParams.Add(name, parameterValue);
				this.Sql.Append(" " + name);
			}
		}
        /// <summary>
        /// 设置表别名
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
		public bool SetTableAlias(string tableName)
		{
			if (!this._dicTableName.Keys.Contains(tableName))
			{
				this._dicTableName.Add(tableName, this._queueEnglishWords.Dequeue());
				return true;
			}
			return false;
		}
        /// <summary>
        /// 获得表别名
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
		public string GetTableAlias(string tableName)
		{
			if (!this.IsSingleTable && this._dicTableName.Keys.Contains(tableName))
			{
				return this._dicTableName[tableName];
			}
			return "";
		}
        /// <summary>
        /// 重写tostring方法
        /// </summary>
        /// <returns></returns>
		public override string ToString()
		{
			return this.Sql.ToString();
		}

	}
}
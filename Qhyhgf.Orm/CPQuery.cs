using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
namespace Qhyhgf.Orm
{
	public sealed class CPQuery
	{
        /// <summary>
        /// 字符串参数的处理进度
        /// </summary>
		private enum SPStep 
		{
            /// <summary>
            /// 没开始或者已完成一次字符串参数的拼接。
            /// </summary>
			NotSet,		
            /// <summary>
            /// 拼接时遇到一个单引号结束
            /// </summary>
			EndWith,	
            /// <summary>
            /// 已跳过一次拼接
            /// </summary>
			Skip
		}
        /// <summary>
        /// 重载字符串可直接转化成cpquery对象
        /// </summary>
        /// <param name="s_sql"></param>
        /// <returns></returns>
        public static implicit operator CPQuery(string s_sql)
        {
            CPQuery tempQuery = new CPQuery(s_sql, false);
            return tempQuery;
        }
		private int _count;
		private StringBuilder _sb = new StringBuilder(1024);
		private Dictionary<string, QueryParameter> _parameters = new Dictionary<string, QueryParameter>(10);

		private bool _autoDiscoverParameters;
		private SPStep _step = SPStep.NotSet;

		public CPQuery(string text, bool autoDiscoverParameters)
		{
			_sb.Append(text);
			_autoDiscoverParameters = autoDiscoverParameters;
		}
        /// <summary>
        /// 创建对象
        /// </summary>
        /// <returns></returns>
		public static CPQuery New()
		{
			return new CPQuery(null, false);
		}
		public static CPQuery New(bool autoDiscoverParameters)
		{
			return new CPQuery(null, autoDiscoverParameters);
		}

		public override string ToString()
		{
			return _sb.ToString();
		}
		public void BindToCommand(DbCommand command)
		{
			if( command == null )
				throw new ArgumentNullException("command");

			command.CommandText = _sb.ToString();
			command.Parameters.Clear();

			foreach( KeyValuePair<string, QueryParameter> kvp in _parameters ) {
				DbParameter p = command.CreateParameter();
				p.ParameterName = kvp.Key;
				p.Value = kvp.Value.Value;
				command.Parameters.Add(p);
			}
		}

		private void AddSqlText(string s)
		{
			if( string.IsNullOrEmpty(s) )
				return;

			if( _autoDiscoverParameters ) {
				if( _step == SPStep.NotSet ) {
					if( s[s.Length - 1] == '\'' ) {	// 遇到一个单引号结束
						_sb.Append(s.Substring(0, s.Length - 1));
						_step = SPStep.EndWith;
					}
					else {
						object val = TryGetValueFromString(s);
						if( val == null )
							_sb.Append(s);
						else
							this.AddParameter(val.AsQueryParameter());
					}
				}
				else if( _step == SPStep.EndWith ) {
					// 此时的s应该是字符串参数，不是SQL语句的一部分
					// _step 在AddParameter方法中统一修改，防止中途拼接非字符串数据。
					this.AddParameter(s.AsQueryParameter());
				}
				else {
					if( s[0] != '\'' )
						throw new ArgumentException("正在等待以单引号开始的字符串，但参数不符合预期格式。");

					// 找到单引号的闭合输入。
					_sb.Append(s.Substring(1));
					_step = SPStep.NotSet;
				}
			}
			else {
				// 不检查单引号结尾的情况，此时认为一定是SQL语句的一部分。
				_sb.Append(s);
			}
		}
		private void AddParameter(QueryParameter p)
		{
			if( _autoDiscoverParameters && _step == SPStep.Skip )
				throw new InvalidOperationException("正在等待以单引号开始的字符串，此时不允许再拼接其它参数。");


			string name = "@p" + (_count++).ToString();
			_sb.Append(name);
			_parameters.Add(name, p);


			if( _autoDiscoverParameters && _step == SPStep.EndWith ) 
				_step = SPStep.Skip;
		}

		private object TryGetValueFromString(string s)
		{
			// 20，可以是byte, short, int, long, uint, ulong ...
			int number1 = 0;
			if( int.TryParse(s, out number1) )
				return number1;

			DateTime dt = DateTime.MinValue;
			if( DateTime.TryParse(s, out dt) )
				return dt;

			// 23.45，可以是float, double, decimal
			decimal number5 = 0m;
			if( decimal.TryParse(s, out number5) )
				return number5;

			// 其它类型全部放弃尝试。
			return null;
		}


		public static CPQuery operator +(CPQuery query, string s)
		{
			query.AddSqlText(s);
			return query;
		}
		public static CPQuery operator +(CPQuery query, QueryParameter p)
		{
			query.AddParameter(p);
			return query;
		}
	}

	public sealed class QueryParameter
	{
		private object _val;

		public QueryParameter(object val)
		{
			_val = val;
		}

		public object Value
		{
			get { return _val; }
		}

		public static explicit operator QueryParameter(string a)
		{
			return new QueryParameter(a);
		}
		public static implicit operator QueryParameter(int a)
		{
			return new QueryParameter(a);
		}
		public static implicit operator QueryParameter(decimal a)
		{
			return new QueryParameter(a);
		}
		public static implicit operator QueryParameter(DateTime a)
		{
			return new QueryParameter(a);
		}
		// 其它需要支持的隐式类型转换操作符重载请自行添加。
	}


	public static class CPQueryExtensions
	{
		public static CPQuery AsCPQuery(this string s)
		{
			return new CPQuery(s, false);
		}
		public static CPQuery AsCPQuery(this string s, bool autoDiscoverParameters)
		{
			return new CPQuery(s,autoDiscoverParameters);
		}

		public static QueryParameter AsQueryParameter(this object b)
		{
			return new QueryParameter(b);
		}
	}

}

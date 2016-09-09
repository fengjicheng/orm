using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Qhyhgf.Orm.Config;

namespace Qhyhgf.Orm.ExpressionEx
{
    /// <summary>
    /// 解析核心
    /// </summary>
    /// <typeparam name="T"></typeparam>
	public class Expression2SqlCore<T>
	{
        /// <summary>
        /// sql参数解析包
        /// </summary>
		private SqlPack _sqlPack = new SqlPack();
        /// <summary>
        /// 解析出的sql
        /// </summary>
		public string SqlStr { get { return this._sqlPack.ToString(); } }
        /// <summary>
        /// 对应的db参数化字典
        /// </summary>
		public Dictionary<string, object> DbParams { get { return this._sqlPack.DbParams; } }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="dbType"></param>
        public Expression2SqlCore(DataSourceType dbType)
		{
			this._sqlPack.DatabaseType = dbType;
		}
        /// <summary>
        /// 清除
        /// </summary>
		public void Clear()
		{
			this._sqlPack.Clear();
		}
        /// <summary>
        /// sql解析
        /// </summary>
        /// <param name="ary">类型集合</param>
        /// <returns></returns>
		private string SelectParser(params Type[] ary)
		{
			this._sqlPack.Clear();
			this._sqlPack.IsSingleTable = false;
            ///循环确定每个表的别名
			foreach (var item in ary)
			{
				string tableName = item.Name;
				this._sqlPack.SetTableAlias(tableName);
			}
            ///拼接sql字符串
			return "select {0}\nfrom " + typeof(T).Name + " " + this._sqlPack.GetTableAlias(typeof(T).Name);
		}
        /// <summary>
        /// Select 解析
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
		public Expression2SqlCore<T> Select(Expression<Func<T, object>> expression = null)
		{
            ///获得sql
			string sql = SelectParser(typeof(T));
            ///判断查询所有字段
			if (expression == null)
			{
				this._sqlPack.Sql.AppendFormat(sql, "*");
			}
			else
			{
                ///解析要查询的字段
				Expression2SqlProvider.Select(expression.Body, this._sqlPack);
				this._sqlPack.Sql.AppendFormat(sql, this._sqlPack.SelectFieldsStr);
			}

			return this;
		}
		public Expression2SqlCore<T> Select<T2>(Expression<Func<T, T2, object>> expression = null)
		{
			string sql = SelectParser(typeof(T), typeof(T2));

			if (expression == null)
			{
				this._sqlPack.Sql.AppendFormat(sql, "*");
			}
			else
			{
				Expression2SqlProvider.Select(expression.Body, this._sqlPack);
				this._sqlPack.Sql.AppendFormat(sql, this._sqlPack.SelectFieldsStr);
			}

			return this;
		}
		public Expression2SqlCore<T> Select<T2, T3>(Expression<Func<T, T2, T3, object>> expression = null)
		{
			string sql = SelectParser(typeof(T), typeof(T2), typeof(T3));

			if (expression == null)
			{
				this._sqlPack.Sql.AppendFormat(sql, "*");
			}
			else
			{
				Expression2SqlProvider.Select(expression.Body, this._sqlPack);
				this._sqlPack.Sql.AppendFormat(sql, this._sqlPack.SelectFieldsStr);
			}

			return this;
		}
		public Expression2SqlCore<T> Select<T2, T3, T4>(Expression<Func<T, T2, T3, T4, object>> expression = null)
		{
			string sql = SelectParser(typeof(T), typeof(T2), typeof(T3), typeof(T4));

			if (expression == null)
			{
				this._sqlPack.Sql.AppendFormat(sql, "*");
			}
			else
			{
				Expression2SqlProvider.Select(expression.Body, this._sqlPack);
				this._sqlPack.Sql.AppendFormat(sql, this._sqlPack.SelectFieldsStr);
			}

			return this;
		}
		public Expression2SqlCore<T> Select<T2, T3, T4, T5>(Expression<Func<T, T2, T3, T4, T5, object>> expression = null)
		{
			string sql = SelectParser(typeof(T), typeof(T2), typeof(T3), typeof(T4), typeof(T5));

			if (expression == null)
			{
				this._sqlPack.Sql.AppendFormat(sql, "*");
			}
			else
			{
				Expression2SqlProvider.Select(expression.Body, this._sqlPack);
				this._sqlPack.Sql.AppendFormat(sql, this._sqlPack.SelectFieldsStr);
			}

			return this;
		}
		public Expression2SqlCore<T> Select<T2, T3, T4, T5, T6>(Expression<Func<T, T2, T3, T4, T5, T6, object>> expression = null)
		{
			string sql = SelectParser(typeof(T), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6));

			if (expression == null)
			{
				this._sqlPack.Sql.AppendFormat(sql, "*");
			}
			else
			{
				Expression2SqlProvider.Select(expression.Body, this._sqlPack);
				this._sqlPack.Sql.AppendFormat(sql, this._sqlPack.SelectFieldsStr);
			}

			return this;
		}
		public Expression2SqlCore<T> Select<T2, T3, T4, T5, T6, T7>(Expression<Func<T, T2, T3, T4, T5, T6, T7, object>> expression = null)
		{
			string sql = SelectParser(typeof(T), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7));

			if (expression == null)
			{
				this._sqlPack.Sql.AppendFormat(sql, "*");
			}
			else
			{
				Expression2SqlProvider.Select(expression.Body, this._sqlPack);
				this._sqlPack.Sql.AppendFormat(sql, this._sqlPack.SelectFieldsStr);
			}

			return this;
		}
		public Expression2SqlCore<T> Select<T2, T3, T4, T5, T6, T7, T8>(Expression<Func<T, T2, T3, T4, T5, T6, T7, T8, object>> expression = null)
		{
			string sql = SelectParser(typeof(T), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8));

			if (expression == null)
			{
				this._sqlPack.Sql.AppendFormat(sql, "*");
			}
			else
			{
				Expression2SqlProvider.Select(expression.Body, this._sqlPack);
				this._sqlPack.Sql.AppendFormat(sql, this._sqlPack.SelectFieldsStr);
			}

			return this;
		}
		public Expression2SqlCore<T> Select<T2, T3, T4, T5, T6, T7, T8, T9>(Expression<Func<T, T2, T3, T4, T5, T6, T7, T8, T9, object>> expression = null)
		{
			string sql = SelectParser(typeof(T), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9));

			if (expression == null)
			{
				this._sqlPack.Sql.AppendFormat(sql, "*");
			}
			else
			{
				Expression2SqlProvider.Select(expression.Body, this._sqlPack);
				this._sqlPack.Sql.AppendFormat(sql, this._sqlPack.SelectFieldsStr);
			}

			return this;
		}
		public Expression2SqlCore<T> Select<T2, T3, T4, T5, T6, T7, T8, T9, T10>(Expression<Func<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, object>> expression = null)
		{
			string sql = SelectParser(typeof(T), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10));

			if (expression == null)
			{
				this._sqlPack.Sql.AppendFormat(sql, "*");
			}
			else
			{
				Expression2SqlProvider.Select(expression.Body, this._sqlPack);
				this._sqlPack.Sql.AppendFormat(sql, this._sqlPack.SelectFieldsStr);
			}

			return this;
		}

		private Expression2SqlCore<T> JoinParser<T2>(Expression<Func<T, T2, bool>> expression, string leftOrRightJoin = "")
		{
			string joinTableName = typeof(T2).Name;
			this._sqlPack.SetTableAlias(joinTableName);
			this._sqlPack.Sql.AppendFormat("\n{0}join {1} on", leftOrRightJoin, joinTableName + " " + this._sqlPack.GetTableAlias(joinTableName));
			Expression2SqlProvider.Join(expression.Body, this._sqlPack);
			return this;
		}
		private Expression2SqlCore<T> JoinParser2<T2, T3>(Expression<Func<T2, T3, bool>> expression, string leftOrRightJoin = "")
		{
			string joinTableName = typeof(T3).Name;
			this._sqlPack.SetTableAlias(joinTableName);
			this._sqlPack.Sql.AppendFormat("\n{0}join {1} on", leftOrRightJoin, joinTableName + " " + this._sqlPack.GetTableAlias(joinTableName));
			Expression2SqlProvider.Join(expression.Body, this._sqlPack);
			return this;
		}

		public Expression2SqlCore<T> Join<T2>(Expression<Func<T, T2, bool>> expression)
		{
			return JoinParser(expression);
		}
		public Expression2SqlCore<T> Join<T2, T3>(Expression<Func<T2, T3, bool>> expression)
		{
			return JoinParser2(expression);
		}

		public Expression2SqlCore<T> InnerJoin<T2>(Expression<Func<T, T2, bool>> expression)
		{
			return JoinParser(expression, "inner ");
		}
		public Expression2SqlCore<T> InnerJoin<T2, T3>(Expression<Func<T2, T3, bool>> expression)
		{
			return JoinParser2(expression, "inner ");
		}

		public Expression2SqlCore<T> LeftJoin<T2>(Expression<Func<T, T2, bool>> expression)
		{
			return JoinParser(expression, "left ");
		}
		public Expression2SqlCore<T> LeftJoin<T2, T3>(Expression<Func<T2, T3, bool>> expression)
		{
			return JoinParser2(expression, "left ");
		}

		public Expression2SqlCore<T> RightJoin<T2>(Expression<Func<T, T2, bool>> expression)
		{
			return JoinParser(expression, "right ");
		}
		public Expression2SqlCore<T> RightJoin<T2, T3>(Expression<Func<T2, T3, bool>> expression)
		{
			return JoinParser2(expression, "right ");
		}

		public Expression2SqlCore<T> FullJoin<T2>(Expression<Func<T, T2, bool>> expression)
		{
			return JoinParser(expression, "full ");
		}
		public Expression2SqlCore<T> FullJoin<T2, T3>(Expression<Func<T2, T3, bool>> expression)
		{
			return JoinParser2(expression, "full ");
		}

		public Expression2SqlCore<T> Where(Expression<Func<T, bool>> expression)
		{
			this._sqlPack += "\nwhere";
			Expression2SqlProvider.Where(expression.Body, this._sqlPack);
			return this;
		}

		public Expression2SqlCore<T> GroupBy(Expression<Func<T, object>> expression)
		{
			this._sqlPack += "\ngroup by ";
			Expression2SqlProvider.GroupBy(expression.Body, this._sqlPack);
			return this;
		}

		public Expression2SqlCore<T> OrderBy(Expression<Func<T, object>> expression)
		{
			this._sqlPack += "\norder by ";
			Expression2SqlProvider.OrderBy(expression.Body, this._sqlPack);
			return this;
		}

		public Expression2SqlCore<T> Max(Expression<Func<T, object>> expression)
		{
			this._sqlPack.Clear();
			this._sqlPack.IsSingleTable = true;
			Expression2SqlProvider.Max(expression.Body, this._sqlPack);
			return this;
		}

		public Expression2SqlCore<T> Min(Expression<Func<T, object>> expression)
		{
			this._sqlPack.Clear();
			this._sqlPack.IsSingleTable = true;
			Expression2SqlProvider.Min(expression.Body, this._sqlPack);
			return this;
		}

		public Expression2SqlCore<T> Avg(Expression<Func<T, object>> expression)
		{
			this._sqlPack.Clear();
			this._sqlPack.IsSingleTable = true;
			Expression2SqlProvider.Avg(expression.Body, this._sqlPack);
			return this;
		}

		public Expression2SqlCore<T> Count(Expression<Func<T, object>> expression = null)
		{
			this._sqlPack.Clear();
			this._sqlPack.IsSingleTable = true;
			if (expression == null)
			{
				this._sqlPack.Sql.AppendFormat("select count(*) from {0}", typeof(T).Name);
			}
			else
			{
				Expression2SqlProvider.Count(expression.Body, this._sqlPack);
			}

			return this;
		}

		public Expression2SqlCore<T> Sum(Expression<Func<T, object>> expression)
		{
			this._sqlPack.Clear();
			this._sqlPack.IsSingleTable = true;
			Expression2SqlProvider.Sum(expression.Body, this._sqlPack);
			return this;
		}

		public Expression2SqlCore<T> Delete()
		{
			this._sqlPack.Clear();
			this._sqlPack.IsSingleTable = true;
			string tableName = typeof(T).Name;
			this._sqlPack.SetTableAlias(tableName);
			this._sqlPack += "delete " + tableName;
			return this;
		}

		public Expression2SqlCore<T> Update(Expression<Func<object>> expression = null)
		{
			this._sqlPack.Clear();
			this._sqlPack.IsSingleTable = true;
			this._sqlPack += "update " + typeof(T).Name + " set ";
			Expression2SqlProvider.Update(expression.Body, this._sqlPack);
			return this;
		}
	}
}

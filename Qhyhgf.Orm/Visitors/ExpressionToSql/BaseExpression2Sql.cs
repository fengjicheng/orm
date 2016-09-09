using System;
using System.Linq.Expressions;

namespace Qhyhgf.Orm.ExpressionEx
{
    /// <summary>
    /// 具体实现
    /// </summary>
    /// <typeparam name="T"></typeparam>
	public abstract class BaseExpression2Sql<T> : IExpression2Sql where T : Expression
    {
        #region 定义虚方法，子类重写
        /// <summary>
        /// Update虚实现
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="sqlPack"></param>
        /// <returns></returns>
		protected virtual SqlPack Update(T expression, SqlPack sqlPack)
		{
			throw new NotImplementedException("未实现" + typeof(T).Name + "2Sql.Update方法");
		}
        /// <summary>
        /// Select虚实现
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="sqlPack"></param>
        /// <returns></returns>
		protected virtual SqlPack Select(T expression, SqlPack sqlPack)
		{
			throw new NotImplementedException("未实现" + typeof(T).Name + "2Sql.Select方法");
		}
        /// <summary>
        /// Join虚实现
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="sqlPack"></param>
        /// <returns></returns>
		protected virtual SqlPack Join(T expression, SqlPack sqlPack)
		{
			throw new NotImplementedException("未实现" + typeof(T).Name + "2Sql.Join方法");
		}
        /// <summary>
        /// Where虚实现
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="sqlPack"></param>
        /// <returns></returns>
		protected virtual SqlPack Where(T expression, SqlPack sqlPack)
		{
			throw new NotImplementedException("未实现" + typeof(T).Name + "2Sql.Where方法");
		}
        /// <summary>
        /// In虚实现
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="sqlPack"></param>
        /// <returns></returns>
		protected virtual SqlPack In(T expression, SqlPack sqlPack)
		{
			throw new NotImplementedException("未实现" + typeof(T).Name + "2Sql.In方法");
		}
        /// <summary>
        /// GroupBy虚实现
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="sqlPack"></param>
        /// <returns></returns>
		protected virtual SqlPack GroupBy(T expression, SqlPack sqlPack)
		{
			throw new NotImplementedException("未实现" + typeof(T).Name + "2Sql.GroupBy方法");
		}
        /// <summary>
        /// OrderBy虚实现
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="sqlPack"></param>
        /// <returns></returns>
		protected virtual SqlPack OrderBy(T expression, SqlPack sqlPack)
		{
			throw new NotImplementedException("未实现" + typeof(T).Name + "2Sql.OrderBy方法");
		}
        /// <summary>
        /// Max虚实现
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="sqlPack"></param>
        /// <returns></returns>
		protected virtual SqlPack Max(T expression, SqlPack sqlPack)
		{
			throw new NotImplementedException("未实现" + typeof(T).Name + "2Sql.Max方法");
		}
        /// <summary>
        /// Min虚实现
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="sqlPack"></param>
        /// <returns></returns>
		protected virtual SqlPack Min(T expression, SqlPack sqlPack)
		{
			throw new NotImplementedException("未实现" + typeof(T).Name + "2Sql.Min方法");
		}
        /// <summary>
        /// Avg虚实现
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="sqlPack"></param>
        /// <returns></returns>
		protected virtual SqlPack Avg(T expression, SqlPack sqlPack)
		{
			throw new NotImplementedException("未实现" + typeof(T).Name + "2Sql.Avg方法");
		}
        /// <summary>
        /// Count虚实现
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="sqlPack"></param>
        /// <returns></returns>
		protected virtual SqlPack Count(T expression, SqlPack sqlPack)
		{
			throw new NotImplementedException("未实现" + typeof(T).Name + "2Sql.Count方法");
		}
        /// <summary>
        /// Sum虚实现
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="sqlPack"></param>
        /// <returns></returns>
		protected virtual SqlPack Sum(T expression, SqlPack sqlPack)
		{
			throw new NotImplementedException("未实现" + typeof(T).Name + "2Sql.Sum方法");
		}
        #endregion
        #region 具体调用
        public SqlPack Update(Expression expression, SqlPack sqlPack)
		{
			return Update((T)expression, sqlPack);
		}
		public SqlPack Select(Expression expression, SqlPack sqlPack)
		{
			return Select((T)expression, sqlPack);
		}
		public SqlPack Join(Expression expression, SqlPack sqlPack)
		{
			return Join((T)expression, sqlPack);
		}
		public SqlPack Where(Expression expression, SqlPack sqlPack)
		{
			return Where((T)expression, sqlPack);
		}
		public SqlPack In(Expression expression, SqlPack sqlPack)
		{
			return In((T)expression, sqlPack);
		}
		public SqlPack GroupBy(Expression expression, SqlPack sqlPack)
		{
			return GroupBy((T)expression, sqlPack);
		}
		public SqlPack OrderBy(Expression expression, SqlPack sqlPack)
		{
			return OrderBy((T)expression, sqlPack);
		}
		public SqlPack Max(Expression expression, SqlPack sqlPack)
		{
			return Max((T)expression, sqlPack);
		}
		public SqlPack Min(Expression expression, SqlPack sqlPack)
		{
			return Min((T)expression, sqlPack);
		}
		public SqlPack Avg(Expression expression, SqlPack sqlPack)
		{
			return Avg((T)expression, sqlPack);
		}
		public SqlPack Count(Expression expression, SqlPack sqlPack)
		{
			return Count((T)expression, sqlPack);
		}
		public SqlPack Sum(Expression expression, SqlPack sqlPack)
		{
			return Sum((T)expression, sqlPack);
        }
        #endregion
    }
}

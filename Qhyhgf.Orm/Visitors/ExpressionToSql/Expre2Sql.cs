using System;
using System.Linq.Expressions;
using Qhyhgf.Orm.Config;

namespace Qhyhgf.Orm.ExpressionEx
{
    /// <summary>
    /// linq查询扩展
    /// </summary>
	public static class Expre2Sql
	{
        /// <summary>
        /// 数据库类型
        /// </summary>
        public static DataSourceType DatabaseType { get; set; }
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        public static void Init(DataSourceType dbType)
		{
			DatabaseType = dbType;
		}
        /// <summary>
        /// 删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
		public static Expression2SqlCore<T> Delete<T>()
		{
            return new Expression2SqlCore<T>(DatabaseType).Delete();
		}
        /// <summary>
        /// 更新
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression"></param>
        /// <returns></returns>
		public static Expression2SqlCore<T> Update<T>(Expression<Func<object>> expression = null)
		{
            return new Expression2SqlCore<T>(DatabaseType).Update(expression);
		}
        # region Select 实现
        /// <summary>
        /// 查询单表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression"></param>
        /// <returns></returns>
		public static Expression2SqlCore<T> Select<T>(Expression<Func<T, object>> expression = null)
		{
            return new Expression2SqlCore<T>(DatabaseType).Select(expression);
		}
        /// <summary>
        /// 双表查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="expression"></param>
        /// <returns></returns>
		public static Expression2SqlCore<T> Select<T, T2>(Expression<Func<T, T2, object>> expression = null)
		{
            return new Expression2SqlCore<T>(DatabaseType).Select(expression);
		}
		public static Expression2SqlCore<T> Select<T, T2, T3>(Expression<Func<T, T2, T3, object>> expression = null)
		{
            return new Expression2SqlCore<T>(DatabaseType).Select(expression);
		}
		public static Expression2SqlCore<T> Select<T, T2, T3, T4>(Expression<Func<T, T2, T3, T4, object>> expression = null)
		{
            return new Expression2SqlCore<T>(DatabaseType).Select(expression);
		}
		public static Expression2SqlCore<T> Select<T, T2, T3, T4, T5>(Expression<Func<T, T2, T3, T4, T5, object>> expression = null)
		{
            return new Expression2SqlCore<T>(DatabaseType).Select(expression);
		}
		public static Expression2SqlCore<T> Select<T, T2, T3, T4, T5, T6>(Expression<Func<T, T2, T3, T4, T5, T6, object>> expression = null)
		{
            return new Expression2SqlCore<T>(DatabaseType).Select(expression);
		}
		public static Expression2SqlCore<T> Select<T, T2, T3, T4, T5, T6, T7>(Expression<Func<T, T2, T3, T4, T5, T6, T7, object>> expression = null)
		{
            return new Expression2SqlCore<T>(DatabaseType).Select(expression);
		}
		public static Expression2SqlCore<T> Select<T, T2, T3, T4, T5, T6, T7, T8>(Expression<Func<T, T2, T3, T4, T5, T6, T7, T8, object>> expression = null)
		{
            return new Expression2SqlCore<T>(DatabaseType).Select(expression);
		}
		public static Expression2SqlCore<T> Select<T, T2, T3, T4, T5, T6, T7, T8, T9>(Expression<Func<T, T2, T3, T4, T5, T6, T7, T8, T9, object>> expression = null)
		{
            return new Expression2SqlCore<T>(DatabaseType).Select(expression);
		}
		public static Expression2SqlCore<T> Select<T, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Expression<Func<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, object>> expression = null)
		{
            return new Expression2SqlCore<T>(DatabaseType).Select(expression);
		}
        #endregion
        #region 聚合函数实现
        /// <summary>
        /// Max扩展
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression"></param>
        /// <returns></returns>
		public static Expression2SqlCore<T> Max<T>(Expression<Func<T, object>> expression)
		{
            return new Expression2SqlCore<T>(DatabaseType).Max(expression);
		}
        /// <summary>
        /// Min扩展
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression"></param>
        /// <returns></returns>
		public static Expression2SqlCore<T> Min<T>(Expression<Func<T, object>> expression)
		{
            return new Expression2SqlCore<T>(DatabaseType).Min(expression);
		}
        /// <summary>
        /// Avg扩展
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression"></param>
        /// <returns></returns>
		public static Expression2SqlCore<T> Avg<T>(Expression<Func<T, object>> expression)
		{
            return new Expression2SqlCore<T>(DatabaseType).Avg(expression);
		}
        /// <summary>
        /// Count扩展
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression"></param>
        /// <returns></returns>
		public static Expression2SqlCore<T> Count<T>(Expression<Func<T, object>> expression = null)
		{
            return new Expression2SqlCore<T>(DatabaseType).Count(expression);
		}
        /// <summary>
        /// sum扩展
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression"></param>
        /// <returns></returns>
		public static Expression2SqlCore<T> Sum<T>(Expression<Func<T, object>> expression)
		{
            return new Expression2SqlCore<T>(DatabaseType).Sum(expression);
        }
        #endregion
    }
}

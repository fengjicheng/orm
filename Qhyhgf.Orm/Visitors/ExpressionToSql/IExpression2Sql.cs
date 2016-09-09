using System.Linq.Expressions;

namespace Qhyhgf.Orm.ExpressionEx
{
    /// <summary>
    /// 可执行动作接口
    /// </summary>
	public interface IExpression2Sql
	{
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="sqlPack"></param>
        /// <returns></returns>
		SqlPack Update(Expression expression, SqlPack sqlPack);
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="sqlPack"></param>
        /// <returns></returns>

		SqlPack Select(Expression expression, SqlPack sqlPack);
        /// <summary>
        /// 连接
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="sqlPack"></param>
        /// <returns></returns>
		SqlPack Join(Expression expression, SqlPack sqlPack);
        /// <summary>
        /// Where条件
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="sqlPack"></param>
        /// <returns></returns>
		SqlPack Where(Expression expression, SqlPack sqlPack);
        /// <summary>
        /// In语句
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="sqlPack"></param>
        /// <returns></returns>
		SqlPack In(Expression expression, SqlPack sqlPack);
        /// <summary>
        /// GroupBy分组查询
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="sqlPack"></param>
        /// <returns></returns>
		SqlPack GroupBy(Expression expression, SqlPack sqlPack);
        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="sqlPack"></param>
        /// <returns></returns>
		SqlPack OrderBy(Expression expression, SqlPack sqlPack);
        /// <summary>
        /// 聚合函数Max
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="sqlPack"></param>
        /// <returns></returns>
		SqlPack Max(Expression expression, SqlPack sqlPack);
        /// <summary>
        /// 聚合函数Min
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="sqlPack"></param>
        /// <returns></returns>
		SqlPack Min(Expression expression, SqlPack sqlPack);
        /// <summary>
        /// 聚合函数Avg
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="sqlPack"></param>
        /// <returns></returns>
		SqlPack Avg(Expression expression, SqlPack sqlPack);
        /// <summary>
        /// 聚合函数Count
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="sqlPack"></param>
        /// <returns></returns>
		SqlPack Count(Expression expression, SqlPack sqlPack);
        /// <summary>
        /// 聚合函数Sum
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="sqlPack"></param>
        /// <returns></returns>
		SqlPack Sum(Expression expression, SqlPack sqlPack);
	}
}

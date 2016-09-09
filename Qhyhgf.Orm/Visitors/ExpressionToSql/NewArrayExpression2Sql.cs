using System.Linq.Expressions;

namespace Qhyhgf.Orm.ExpressionEx
{
    /// <summary>
    /// 表示创建新数组并可能初始化该新数组的元素。
    /// </summary>
	class NewArrayExpression2Sql : BaseExpression2Sql<NewArrayExpression>
	{
		protected override SqlPack In(NewArrayExpression expression, SqlPack sqlPack)
		{
			sqlPack += "(";
            //拼接具体值
			foreach (Expression expressionItem in expression.Expressions)
			{
				Expression2SqlProvider.In(expressionItem, sqlPack);
			}

			if (sqlPack.Sql[sqlPack.Sql.Length - 1] == ',')
			{
				sqlPack.Sql.Remove(sqlPack.Sql.Length - 1, 1);
			}

			sqlPack += ")";

			return sqlPack;
		}
	}
}

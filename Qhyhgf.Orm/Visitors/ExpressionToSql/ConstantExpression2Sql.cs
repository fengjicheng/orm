
using System.Linq.Expressions;

namespace Qhyhgf.Orm.ExpressionEx
{
    /// <summary>
    ///  表示具有常量值的表达式。
    /// </summary>
	class ConstantExpression2Sql : BaseExpression2Sql<ConstantExpression>
	{
		protected override SqlPack Where(ConstantExpression expression, SqlPack sqlPack)
		{
			sqlPack.AddDbParameter(expression.Value);
			return sqlPack;
		}

		protected override SqlPack In(ConstantExpression expression, SqlPack sqlPack)
		{
			if (expression.Type.Name == "String")
			{
				sqlPack.Sql.AppendFormat("'{0}',", expression.Value);
			}
			else
			{
				sqlPack.Sql.AppendFormat("{0},", expression.Value);
			}
			return sqlPack;
		}
	}
}
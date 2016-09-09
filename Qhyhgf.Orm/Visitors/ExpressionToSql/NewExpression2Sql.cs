
using System.Linq.Expressions;
using System.Reflection;

namespace Qhyhgf.Orm.ExpressionEx
{
    /// <summary>
    /// 表示构造函数调用。
    /// </summary>
	class NewExpression2Sql : BaseExpression2Sql<NewExpression>
	{
		protected override SqlPack Update(NewExpression expression, SqlPack sqlPack)
		{
			for (int i = 0; i < expression.Members.Count; i++)
			{
				MemberInfo m = expression.Members[i];
				ConstantExpression c = expression.Arguments[i] as ConstantExpression;
				sqlPack += m.Name + " =";
				sqlPack.AddDbParameter(c.Value);
				sqlPack += ",";
			}
			if (sqlPack[sqlPack.Length - 1] == ',')
			{
				sqlPack.Sql.Remove(sqlPack.Length - 1, 1);
			}
			return sqlPack;
		}

		protected override SqlPack Select(NewExpression expression, SqlPack sqlPack)
		{
			foreach (Expression item in expression.Arguments)
			{
				Expression2SqlProvider.Select(item, sqlPack);
			}
			return sqlPack;
		}

		protected override SqlPack GroupBy(NewExpression expression, SqlPack sqlPack)
		{
			foreach (Expression item in expression.Arguments)
			{
				Expression2SqlProvider.GroupBy(item, sqlPack);
			}
			return sqlPack;
		}

		protected override SqlPack OrderBy(NewExpression expression, SqlPack sqlPack)
		{
			foreach (Expression item in expression.Arguments)
			{
				Expression2SqlProvider.OrderBy(item, sqlPack);
			}
			return sqlPack;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Qhyhgf.Orm.ExpressionEx
{
    /// <summary>
    /// 表示对静态方法或实例方法的调用。
    /// </summary>
	class MethodCallExpression2Sql : BaseExpression2Sql<MethodCallExpression>
	{
        /// <summary>
        /// 支持的方法
        /// </summary>
		static Dictionary<string, Action<MethodCallExpression, SqlPack>> _Methods = new Dictionary<string, Action<MethodCallExpression, SqlPack>>
        {
            {"Like",Like},
            {"LikeLeft",LikeLeft},
            {"LikeRight",LikeRight},
            {"In",In}
        };

		private static void In(MethodCallExpression expression, SqlPack sqlPack)
		{
			Expression2SqlProvider.Where(expression.Arguments[0], sqlPack);
			sqlPack += " in";
			Expression2SqlProvider.In(expression.Arguments[1], sqlPack);
		}

		private static void Like(MethodCallExpression expression, SqlPack sqlPack)
		{
			if (expression.Object != null)
			{
				Expression2SqlProvider.Where(expression.Object, sqlPack);
			}
			Expression2SqlProvider.Where(expression.Arguments[0], sqlPack);
			sqlPack += " like '%' +";
			Expression2SqlProvider.Where(expression.Arguments[1], sqlPack);
			sqlPack += " + '%'";
		}

		private static void LikeLeft(MethodCallExpression expression, SqlPack sqlPack)
		{
			if (expression.Object != null)
			{
				Expression2SqlProvider.Where(expression.Object, sqlPack);
			}
			Expression2SqlProvider.Where(expression.Arguments[0], sqlPack);
			sqlPack += " like '%' +";
			Expression2SqlProvider.Where(expression.Arguments[1], sqlPack);
		}

		private static void LikeRight(MethodCallExpression expression, SqlPack sqlPack)
		{
			if (expression.Object != null)
			{
				Expression2SqlProvider.Where(expression.Object, sqlPack);
			}
			Expression2SqlProvider.Where(expression.Arguments[0], sqlPack);
			sqlPack += " like ";
			Expression2SqlProvider.Where(expression.Arguments[1], sqlPack);
			sqlPack += " + '%'";
		}


		protected override SqlPack Where(MethodCallExpression expression, SqlPack sqlPack)
		{
			var key = expression.Method;
			if (key.IsGenericMethod)
			{
				key = key.GetGenericMethodDefinition();
			}

			Action<MethodCallExpression, SqlPack> action;
			if (_Methods.TryGetValue(key.Name, out action))
			{
				action(expression, sqlPack);
				return sqlPack;
			}

			throw new NotImplementedException("无法解析方法" + expression.Method);
		}
	}
}
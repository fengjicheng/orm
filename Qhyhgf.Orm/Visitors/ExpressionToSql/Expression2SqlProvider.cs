using System;
using System.Linq.Expressions;

namespace Qhyhgf.Orm.ExpressionEx
{
	internal class Expression2SqlProvider
	{
        /// <summary>
        /// 判断 Expression 类型，返回解析的Provider
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
		private static IExpression2Sql GetExpression2Sql(Expression expression)
		{
            ///如果表达式为空
			if (expression == null)
			{
				throw new ArgumentNullException("expression", "不能为null");
			}
            //若表示包含二元运算符的表达式。
			if (expression is BinaryExpression)
			{
				return new BinaryExpression2Sql();
			}
            ///若表示一个包含可在其中定义变量的表达式序列的块。
			if (expression is BlockExpression)
			{
				throw new NotImplementedException("未实现的BlockExpression2Sql");
			}
            ///若表示包含条件运算符的表达式。
			if (expression is ConditionalExpression)
			{
				throw new NotImplementedException("未实现的ConditionalExpression2Sql");
			}
            //若 表示具有常量值的表达式。
			if (expression is ConstantExpression)
			{
				return new ConstantExpression2Sql();
			}
            //若表示发出或清除调试信息的序列点。这允许调试器在调试时突出显示正确的源代码。
			if (expression is DebugInfoExpression)
			{
				throw new NotImplementedException("未实现的DebugInfoExpression2Sql");
			}
            ///若表示类型或空表达式的默认值。
			if (expression is DefaultExpression)
			{
				throw new NotImplementedException("未实现的DefaultExpression2Sql");
			}
            ///若表示动态操作。
			if (expression is DynamicExpression)
			{
				throw new NotImplementedException("未实现的DynamicExpression2Sql");
			}
            ///若表示无条件跳转。这包括 return 语句、break 和 continue 语句以及其他跳转。
			if (expression is GotoExpression)
			{
				throw new NotImplementedException("未实现的GotoExpression2Sql");
			}
            ///若表示编制属性或数组的索引。
			if (expression is IndexExpression)
			{
				throw new NotImplementedException("未实现的IndexExpression2Sql");
			}
            ///若表示将委托或 lambda 表达式应用于参数表达式列表的表达式。
			if (expression is InvocationExpression)
			{
				throw new NotImplementedException("未实现的InvocationExpression2Sql");
			}
            //若 表示一个标签，可以将该标签放置在任何
			if (expression is LabelExpression)
			{
				throw new NotImplementedException("未实现的LabelExpression2Sql");
			}
            ///若描述一个 lambda 表达式。这将捕获与 .NET 方法体类似的代码块。
			if (expression is LambdaExpression)
			{
				throw new NotImplementedException("未实现的LambdaExpression2Sql");
			}
            //若表示包含集合初始值设定项的构造函数调用。
			if (expression is ListInitExpression)
			{
				throw new NotImplementedException("未实现的ListInitExpression2Sql");
			}
            //若表示无限循环。可以使用“break”退出它。
			if (expression is LoopExpression)
			{
				throw new NotImplementedException("未实现的LoopExpression2Sql");
			}
            ///若表示访问字段或属性。
			if (expression is MemberExpression)
			{
				return new MemberExpression2Sql();
			}
            //若表示调用构造函数并初始化新对象的一个或多个成员。
			if (expression is MemberInitExpression)
			{
				throw new NotImplementedException("未实现的MemberInitExpression2Sql");
			}
            ///若表示对静态方法或实例方法的调用。
			if (expression is MethodCallExpression)
			{
				return new MethodCallExpression2Sql();
			}
            ///若表示创建新数组并可能初始化该新数组的元素。
			if (expression is NewArrayExpression)
			{
				return new NewArrayExpression2Sql();
			}
            ///若表示构造函数调用。
			if (expression is NewExpression)
			{
				return new NewExpression2Sql();
			}
            ///若表示命名的参数表达式。
			if (expression is ParameterExpression)
			{
				throw new NotImplementedException("未实现的ParameterExpression2Sql");
			}
            ///若一个为变量提供运行时读/写权限的表达式。
			if (expression is RuntimeVariablesExpression)
			{
				throw new NotImplementedException("未实现的RuntimeVariablesExpression2Sql");
			}
            ///若表示一个控制表达式，该表达式通过将控制传递到 System.Linq.Expressions.SwitchCase 来处理多重选择。
			if (expression is SwitchExpression)
			{
				throw new NotImplementedException("未实现的SwitchExpression2Sql");
			}
            /// 表示 try/catch/finally/fault 块。
			if (expression is TryExpression)
			{
				throw new NotImplementedException("未实现的TryExpression2Sql");
			}
            ///表示表达式和类型之间的操作
			if (expression is TypeBinaryExpression)
			{
				throw new NotImplementedException("未实现的TypeBinaryExpression2Sql");
			}
            ///表示包含一元运算符的表达式。
			if (expression is UnaryExpression)
			{
				return new UnaryExpression2Sql();
			}
            //若都匹配不上，则抛出异常
			throw new NotImplementedException("未实现的Expression2Sql");
		}

		public static void Update(Expression expression, SqlPack sqlPack)
		{
			GetExpression2Sql(expression).Update(expression, sqlPack);
		}

		public static void Select(Expression expression, SqlPack sqlPack)
		{
            //解析select 字段
			GetExpression2Sql(expression).Select(expression, sqlPack);
		}

		public static void Join(Expression expression, SqlPack sqlPack)
		{
			GetExpression2Sql(expression).Join(expression, sqlPack);
		}

		public static void Where(Expression expression, SqlPack sqlPack)
		{
			GetExpression2Sql(expression).Where(expression, sqlPack);
		}

		public static void In(Expression expression, SqlPack sqlPack)
		{
			GetExpression2Sql(expression).In(expression, sqlPack);
		}

		public static void GroupBy(Expression expression, SqlPack sqlPack)
		{
			GetExpression2Sql(expression).GroupBy(expression, sqlPack);
		}

		public static void OrderBy(Expression expression, SqlPack sqlPack)
		{
			GetExpression2Sql(expression).OrderBy(expression, sqlPack);
		}

		public static void Max(Expression expression, SqlPack sqlPack)
		{
			GetExpression2Sql(expression).Max(expression, sqlPack);
		}

		public static void Min(Expression expression, SqlPack sqlPack)
		{
			GetExpression2Sql(expression).Min(expression, sqlPack);
		}

		public static void Avg(Expression expression, SqlPack sqlPack)
		{
			GetExpression2Sql(expression).Avg(expression, sqlPack);
		}

		public static void Count(Expression expression, SqlPack sqlPack)
		{
			GetExpression2Sql(expression).Count(expression, sqlPack);
		}

		public static void Sum(Expression expression, SqlPack sqlPack)
		{
			GetExpression2Sql(expression).Sum(expression, sqlPack);
		}
	}
}

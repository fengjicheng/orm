﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
/*
                           _ooOoo_
                          o8888888o
                          88" . "88
                          (| -_- |)
                          O\  =  /O
                       ____/`---'\____
                     .'  \\|     |//  `.
                    /  \\|||  :  |||//  \
                   /  _||||| -:- |||||-  \
                   |   | \\\  -  /// |   |
                   | \_|  ''\---/''  |   |
                   \  .-\__  `-`  ___/-. /
                 ___`. .'  /--.--\  `. . __
              ."" '<  `.___\_<|>_/___.'  >'"".
             | | :  `- \`.;`\ _ /`;.`/ - ` : | |
             \  \ `-.   \_ __\ /__ _/   .-` /  /
        ======`-.____`-.___\_____/___.-`____.-'======
                           `=---='
        ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
                 佛祖保佑       永无BUG
        *********************************************
        * 作者：冯际成
        * 单位：青海盐湖工业股份有限公司信息中心
        * 电话：15209793953
 */

//-------------------------------------------------------------
// 代码来源于Fish Li的博客示例，博客网址：
//		http://www.cnblogs.com/fish-li/archive/2013/02/18/2916253.html

// 使用方法

// 1. 先引用命名空间： using OptimizeReflection;

// 2. 参考下面的代码调用 FastInvoke(...)

/*
	Type instanceType = typeof(DemoClass);
	MethodInfo methodInfo = instanceType.GetMethod("Add");

	// 调用方法
	int c = (int)methodInfo.FastInvoke(obj, 1, 2);
	int d = (int)methodInfo.FastInvoke2(obj, 3, 4);
*/
//-------------------------------------------------------------

namespace Qhyhgf.WeiXin.Qy.Api.Dynamic
{
	#region 委托定义

	public delegate void InstanceAction<TTarget>(TTarget target);
	public delegate void InstanceAction<TTarget, A1>(TTarget target, A1 arg1);
	public delegate void InstanceAction<TTarget, A1, A2>(TTarget target, A1 arg1, A2 arg2);
	public delegate void InstanceAction<TTarget, A1, A2, A3>(TTarget target, A1 arg1, A2 arg2, A3 arg3);
	public delegate void InstanceAction<TTarget, A1, A2, A3, A4>(TTarget target, A1 arg1, A2 arg2, A3 arg3, A4 arg4);
	public delegate void InstanceAction<TTarget, A1, A2, A3, A4, A5>(TTarget target, A1 arg1, A2 arg2, A3 arg3, A4 arg4, A5 arg5);
	public delegate void InstanceAction<TTarget, A1, A2, A3, A4, A5, A6>(TTarget target, A1 arg1, A2 arg2, A3 arg3, A4 arg4, A5 arg5, A6 arg6);
	public delegate void InstanceAction<TTarget, A1, A2, A3, A4, A5, A6, A7>(TTarget target, A1 arg1, A2 arg2, A3 arg3, A4 arg4, A5 arg5, A6 arg6, A7 arg7);
	public delegate void InstanceAction<TTarget, A1, A2, A3, A4, A5, A6, A7, A8>(TTarget target, A1 arg1, A2 arg2, A3 arg3, A4 arg4, A5 arg5, A6 arg6, A7 arg7, A8 arg8);
	public delegate void InstanceAction<TTarget, A1, A2, A3, A4, A5, A6, A7, A8, A9>(TTarget target, A1 arg1, A2 arg2, A3 arg3, A4 arg4, A5 arg5, A6 arg6, A7 arg7, A8 arg8, A9 arg9);

	public delegate void StaticAction();
	public delegate void StaticAction<A1>(A1 arg1);
	public delegate void StaticAction<A1, A2>(A1 arg1, A2 arg2);
	public delegate void StaticAction<A1, A2, A3>(A1 arg1, A2 arg2, A3 arg3);
	public delegate void StaticAction<A1, A2, A3, A4>(A1 arg1, A2 arg2, A3 arg3, A4 arg4);
	public delegate void StaticAction<A1, A2, A3, A4, A5>(A1 arg1, A2 arg2, A3 arg3, A4 arg4, A5 arg5);
	public delegate void StaticAction<A1, A2, A3, A4, A5, A6>(A1 arg1, A2 arg2, A3 arg3, A4 arg4, A5 arg5, A6 arg6);
	public delegate void StaticAction<A1, A2, A3, A4, A5, A6, A7>(A1 arg1, A2 arg2, A3 arg3, A4 arg4, A5 arg5, A6 arg6, A7 arg7);
	public delegate void StaticAction<A1, A2, A3, A4, A5, A6, A7, A8>(A1 arg1, A2 arg2, A3 arg3, A4 arg4, A5 arg5, A6 arg6, A7 arg7, A8 arg8);
	public delegate void StaticAction<A1, A2, A3, A4, A5, A6, A7, A8, A9>(A1 arg1, A2 arg2, A3 arg3, A4 arg4, A5 arg5, A6 arg6, A7 arg7, A8 arg8, A9 arg9);

	public delegate TResult InstanceFunc<TTarget, TResult>(TTarget target);
	public delegate TResult InstanceFunc<TTarget, A1, TResult>(TTarget target, A1 arg1);
	public delegate TResult InstanceFunc<TTarget, A1, A2, TResult>(TTarget target, A1 arg1, A2 arg2);
	public delegate TResult InstanceFunc<TTarget, A1, A2, A3, TResult>(TTarget target, A1 arg1, A2 arg2, A3 arg3);
	public delegate TResult InstanceFunc<TTarget, A1, A2, A3, A4, TResult>(TTarget target, A1 arg1, A2 arg2, A3 arg3, A4 arg4);
	public delegate TResult InstanceFunc<TTarget, A1, A2, A3, A4, A5, TResult>(TTarget target, A1 arg1, A2 arg2, A3 arg3, A4 arg4, A5 arg5);
	public delegate TResult InstanceFunc<TTarget, A1, A2, A3, A4, A5, A6, TResult>(TTarget target, A1 arg1, A2 arg2, A3 arg3, A4 arg4, A5 arg5, A6 arg6);
	public delegate TResult InstanceFunc<TTarget, A1, A2, A3, A4, A5, A6, A7, TResult>(TTarget target, A1 arg1, A2 arg2, A3 arg3, A4 arg4, A5 arg5, A6 arg6, A7 arg7);
	public delegate TResult InstanceFunc<TTarget, A1, A2, A3, A4, A5, A6, A7, A8, TResult>(TTarget target, A1 arg1, A2 arg2, A3 arg3, A4 arg4, A5 arg5, A6 arg6, A7 arg7, A8 arg8);
	public delegate TResult InstanceFunc<TTarget, A1, A2, A3, A4, A5, A6, A7, A8, A9, TResult>(TTarget target, A1 arg1, A2 arg2, A3 arg3, A4 arg4, A5 arg5, A6 arg6, A7 arg7, A8 arg8, A9 arg9);

	public delegate TResult StaticFunc<TResult>();
	public delegate TResult StaticFunc<A1, TResult>(A1 arg1);
	public delegate TResult StaticFunc<A1, A2, TResult>(A1 arg1, A2 arg2);
	public delegate TResult StaticFunc<A1, A2, A3, TResult>(A1 arg1, A2 arg2, A3 arg3);
	public delegate TResult StaticFunc<A1, A2, A3, A4, TResult>(A1 arg1, A2 arg2, A3 arg3, A4 arg4);
	public delegate TResult StaticFunc<A1, A2, A3, A4, A5, TResult>(A1 arg1, A2 arg2, A3 arg3, A4 arg4, A5 arg5);
	public delegate TResult StaticFunc<A1, A2, A3, A4, A5, A6, TResult>(A1 arg1, A2 arg2, A3 arg3, A4 arg4, A5 arg5, A6 arg6);
	public delegate TResult StaticFunc<A1, A2, A3, A4, A5, A6, A7, TResult>(A1 arg1, A2 arg2, A3 arg3, A4 arg4, A5 arg5, A6 arg6, A7 arg7);
	public delegate TResult StaticFunc<A1, A2, A3, A4, A5, A6, A7, A8, TResult>(A1 arg1, A2 arg2, A3 arg3, A4 arg4, A5 arg5, A6 arg6, A7 arg7, A8 arg8);
	public delegate TResult StaticFunc<A1, A2, A3, A4, A5, A6, A7, A8, A9, TResult>(A1 arg1, A2 arg2, A3 arg3, A4 arg4, A5 arg5, A6 arg6, A7 arg7, A8 arg8, A9 arg9);

	#endregion

	/// <summary>
	/// 定义了通用的方法调用接口
	/// </summary>
	public interface IInvokeMethod
	{
		object Invoke(object target, object[] parameters);
	}

	// 增加这个方法完全是为了简化ReflectMethodBase的继承类的实现代码
	internal interface IBindMethod
	{
		void BindMethod(MethodInfo method);
	}

	/// <summary>
	/// 创建IInvokeMethod实例的工厂类
	/// </summary>
	public static class MethodInvokerFactory
	{
		private static readonly Hashtable s_dict = Hashtable.Synchronized(new Hashtable(10240));

		private static readonly Dictionary<string, Type> s_genericTypeDefinitions;

		static MethodInvokerFactory()
		{
			Type reflectMethodBase = typeof(ReflectMethodBase<>).GetGenericTypeDefinition();

			s_genericTypeDefinitions = (from t in typeof(MethodInvokerFactory).Assembly.GetExportedTypes()
										where t.BaseType != null
										&& t.BaseType.IsGenericType
										&& t.BaseType.GetGenericTypeDefinition() == reflectMethodBase
										select t).ToDictionary(x => x.Name);

			// 说明：这个工厂还有一种设计方法，
			// 直接分析类型的基类，检查是不是从ReflectMethodBase<>继承过来的，
			// 再分析类型参数中的委托的类型参数，从而得知这个类型可用于处理哪类方法的优化，
			// 并可以生成KEY，这样就不必与类型的名字有关了。
			// 但这种方法也有麻烦问题：由于每个实现类的类名没有名字上的约束，有可能生成相同的KEY，
			// 因为不同的类型都可以用于某一类方法的优化的，KEY就自然相同了。
			// 也正因为这个原因，CreateMethodWrapper 方法在生成KEY时，需要每个实现类的名字符合一定的约束条件。
		}

		internal static IInvokeMethod GetMethodInvokerWrapper(MethodInfo methodInfo)
		{
			IInvokeMethod method = (IInvokeMethod)s_dict[methodInfo];
			if( method == null ) {
				method = CreateMethodInvokerWrapper(methodInfo);
				s_dict[methodInfo] = method;
			}

			return method;
		}

		/// <summary>
		/// 根据指定的MethodInfo对象创建相应的IInvokeMethod实例。
		/// </summary>
		/// <param name="method"></param>
		/// <returns></returns>
		public static IInvokeMethod CreateMethodInvokerWrapper(MethodInfo method)
		{
			// 在这个类型的静态构造方法中，我已将所有能优化反射调用的泛型找出来，保存在s_genericTypeDefinitions中。
			// 这个工厂方法将根据：
			//	    1. 方法是否有返回值，
			//	    2. 方法是静态的，还是实例的，
			//	    3. 方法有多少个参数
			// 来查找能优化指定方法的那个泛型类型。

			// 不过，s_genericTypeDefinitions保存的泛型定义，属于开放泛型，
			// 工厂方法还要根据指定方法来填充类型参数，最后创建特定的泛型实例。

			if( method == null )
				throw new ArgumentNullException("method");

			ParameterInfo[] pameters = method.GetParameters();
			
			// 1. 首先根据指定方法的签名计算缓存键值
			string key = null;
			if( method.ReturnType == typeof(void) ) {
				if( method.IsStatic ) {
					if( pameters.Length == 0 )
						key = "StaticActionWrapper";
					else
						key = "StaticActionWrapper`" + pameters.Length.ToString();
				}
				else
					key = "ActionWrapper`" + (pameters.Length + 1).ToString();
			}
			else {
				if( method.IsStatic )
					key = "StaticFunctionWrapper`" + (pameters.Length + 1).ToString();
				else
					key = "FunctionWrapper`" + (pameters.Length + 2).ToString();
			}

			// 2. 查找缓存，获取泛型定义
			Type genericTypeDefinition;
			if( s_genericTypeDefinitions.TryGetValue(key, out genericTypeDefinition) == false )
				// 如果找不到一个泛型类型，就返回下面这个通用的类型。
				// 下面这个类型将不会优化反射调用。
				return new CommonInvokerWrapper(method);


			Type instanceType = null;
			if( genericTypeDefinition.IsGenericTypeDefinition ) {
				// 3. 获取填充泛型定义的类型参数。
				List<Type> list = new List<Type>(pameters.Length + 2);
				if( method.IsStatic == false )
					list.Add(method.DeclaringType);

				for( int i = 0; i < pameters.Length; i++ )
					list.Add(pameters[i].ParameterType);

				if( method.ReturnType != typeof(void) )
					list.Add(method.ReturnType);

				// 4. 将泛型定义转成封闭泛型。
				instanceType = genericTypeDefinition.MakeGenericType(list.ToArray());
			}
			else
				instanceType = genericTypeDefinition;

			// 5. 实例化IReflectMethod对象。
			IInvokeMethod instance = (IInvokeMethod)Activator.CreateInstance(instanceType);

			IBindMethod binder = instance as IBindMethod;
			if( binder != null )
				binder.BindMethod(method);

			return instance;
		}
	}

	/// <summary>
	/// 一些扩展方法，用于快速调用方法，它们都可以优化反射性能。
	/// </summary>
	public static class MethodExtensions
	{
		/// <summary>
		/// 根据指定的MethodInfo以及参数数组，快速调用相关的方法。
		/// </summary>
		/// <param name="methodInfo"></param>
		/// <param name="obj"></param>
		/// <param name="parameters"></param>
		/// <returns></returns>
		public static object FastInvoke(this MethodInfo methodInfo, object obj, params object[] parameters)
		{
			if( methodInfo == null )
				throw new ArgumentNullException("methodInfo");

			IInvokeMethod method = MethodInvokerFactory.GetMethodInvokerWrapper(methodInfo);
			return method.Invoke(obj, parameters);
		}
	}

	/// <summary>
	/// 为了简化实现IInvokeMethod接口的抽象类，继承类只需要重写InvokeInternal方法即可。
	/// </summary>
	/// <typeparam name="TDelegate"></typeparam>
	public abstract class ReflectMethodBase<TDelegate> : IInvokeMethod, IBindMethod where TDelegate : class
	{
		protected TDelegate _caller;
		protected object _returnValue;

		public void BindMethod(MethodInfo method)
		{
			if( method == null )
				throw new ArgumentNullException("method");

			if( method.IsStatic )
				_caller = Delegate.CreateDelegate(typeof(TDelegate), method) as TDelegate;
			else
				_caller = Delegate.CreateDelegate(typeof(TDelegate), null, method) as TDelegate;
		}

		public object Invoke(object target, object[] parameters)
		{
			if( _caller == null )
				throw new InvalidOperationException("在调用Invoke之前没有调用BindMethod方法。");

			InvokeInternal(target, parameters);
			return _returnValue;
		}
		protected abstract void InvokeInternal(object target, object[] parameters);
	}

	internal class CommonInvokerWrapper : IInvokeMethod
	{
		private MethodInfo _method;

		public CommonInvokerWrapper(MethodInfo method)
		{
			if( method == null )
				throw new ArgumentNullException("method");

			_method = method;
		}

		public object Invoke(object target, object[] parameters)
		{
			if( _method.ReturnType == typeof(void) ) {
				_method.Invoke(target, parameters);
				return null;
			}

			return _method.Invoke(target, parameters);
		}
	}
		
	#region   第一组，无参数。

	public partial class ActionWrapper<TTarget> : ReflectMethodBase<InstanceAction<TTarget>>
	{
		protected override void InvokeInternal(object target, object[] parameters)
		{
			_caller((TTarget)target);
		}
	}

	public partial class StaticActionWrapper : ReflectMethodBase<StaticAction>
	{
		protected override void InvokeInternal(object target, object[] parameters)
		{
			_caller();
		}
	}

	public partial class FunctionWrapper<TTarget, TResult> : ReflectMethodBase<InstanceFunc<TTarget, TResult>>
	{
		protected override void InvokeInternal(object target, object[] parameters)
		{
			_returnValue = _caller((TTarget)target);
		}
	}

	public partial class StaticFunctionWrapper<TResult> : ReflectMethodBase<StaticFunc<TResult>>
	{
		protected override void InvokeInternal(object target, object[] parameters)
		{
			_returnValue = _caller();
		}
	}

	#endregion

	#region  第 2 组，1个参数。

	public partial class ActionWrapper<TTarget, A1> : ReflectMethodBase<InstanceAction<TTarget, A1>>
	{
		protected override void InvokeInternal(object target, object[] parameters)
		{
			_caller((TTarget)target, (A1)parameters[0]);
		}
	}

	public partial class StaticActionWrapper<A1> : ReflectMethodBase<StaticAction<A1>>
	{
		protected override void InvokeInternal(object target, object[] parameters)
		{
			_caller((A1)parameters[0]);
		}
	}

	public partial class FunctionWrapper<TTarget, A1, TResult> : ReflectMethodBase<InstanceFunc<TTarget, A1, TResult>>
	{
		protected override void InvokeInternal(object target, object[] parameters)
		{
			_returnValue = _caller((TTarget)target, (A1)parameters[0]);
		}
	}

	public partial class StaticFunctionWrapper<A1, TResult> : ReflectMethodBase<StaticFunc<A1, TResult>>
	{
		protected override void InvokeInternal(object target, object[] parameters)
		{
			_returnValue = _caller((A1)parameters[0]);
		}
	}

	#endregion
	
	#region  第 3 组，2个参数。
	
	public partial class ActionWrapper<TTarget, A1, A2> : ReflectMethodBase<InstanceAction<TTarget, A1, A2>>
	{
		protected override void InvokeInternal(object target, object[] parameters)
		{
			_caller((TTarget)target, (A1)parameters[0], (A2)parameters[1]);
		}
	}

	public partial class StaticActionWrapper<A1, A2> : ReflectMethodBase<StaticAction<A1, A2>>
	{
		protected override void InvokeInternal(object target, object[] parameters)
		{
			_caller((A1)parameters[0], (A2)parameters[1]);
		}
	}

	public partial class FunctionWrapper<TTarget, A1, A2, TResult> : ReflectMethodBase<InstanceFunc<TTarget, A1, A2, TResult>>
	{
		protected override void InvokeInternal(object target, object[] parameters)
		{
			_returnValue = _caller((TTarget)target, (A1)parameters[0], (A2)parameters[1]);
		}
	}

	public partial class StaticFunctionWrapper<A1, A2, TResult> : ReflectMethodBase<StaticFunc<A1, A2, TResult>>
	{
		protected override void InvokeInternal(object target, object[] parameters)
		{
			_returnValue = _caller((A1)parameters[0], (A2)parameters[1]);
		}
	}
	
	#endregion

	#region  第 4 组，3个参数。

	public partial class ActionWrapper<TTarget, A1, A2, A3> : ReflectMethodBase<InstanceAction<TTarget, A1, A2, A3>>
	{
		protected override void InvokeInternal(object target, object[] parameters)
		{
			_caller((TTarget)target, (A1)parameters[0], (A2)parameters[1], (A3)parameters[2]);
		}
	}

	public partial class StaticActionWrapper<A1, A2, A3> : ReflectMethodBase<StaticAction<A1, A2, A3>>
	{
		protected override void InvokeInternal(object target, object[] parameters)
		{
			_caller((A1)parameters[0], (A2)parameters[1], (A3)parameters[2]);
		}
	}

	public partial class FunctionWrapper<TTarget, A1, A2, A3, TResult> : ReflectMethodBase<InstanceFunc<TTarget, A1, A2, A3, TResult>>
	{
		protected override void InvokeInternal(object target, object[] parameters)
		{
			_returnValue = _caller((TTarget)target, (A1)parameters[0], (A2)parameters[1], (A3)parameters[2]);
		}
	}

	public partial class StaticFunctionWrapper<A1, A2, A3, TResult> : ReflectMethodBase<StaticFunc<A1, A2, A3, TResult>>
	{
		protected override void InvokeInternal(object target, object[] parameters)
		{
			_returnValue = _caller((A1)parameters[0], (A2)parameters[1], (A3)parameters[2]);
		}
	}
	
	#endregion

	#region  第 5 组，4个参数。

	public partial class ActionWrapper<TTarget, A1, A2, A3, A4> : ReflectMethodBase<InstanceAction<TTarget, A1, A2, A3, A4>>
	{
		protected override void InvokeInternal(object target, object[] parameters)
		{
			_caller((TTarget)target, (A1)parameters[0], (A2)parameters[1], (A3)parameters[2], (A4)parameters[3]);
		}
	}

	public partial class StaticActionWrapper<A1, A2, A3, A4> : ReflectMethodBase<StaticAction<A1, A2, A3, A4>>
	{
		protected override void InvokeInternal(object target, object[] parameters)
		{
			_caller((A1)parameters[0], (A2)parameters[1], (A3)parameters[2], (A4)parameters[3]);
		}
	}

	public partial class FunctionWrapper<TTarget, A1, A2, A3, A4, TResult> : ReflectMethodBase<InstanceFunc<TTarget, A1, A2, A3, A4, TResult>>
	{
		protected override void InvokeInternal(object target, object[] parameters)
		{
			_returnValue = _caller((TTarget)target, (A1)parameters[0], (A2)parameters[1], (A3)parameters[2], (A4)parameters[3]);
		}
	}

	public partial class StaticFunctionWrapper<A1, A2, A3, A4, TResult> : ReflectMethodBase<StaticFunc<A1, A2, A3, A4, TResult>>
	{
		protected override void InvokeInternal(object target, object[] parameters)
		{
			_returnValue = _caller((A1)parameters[0], (A2)parameters[1], (A3)parameters[2], (A4)parameters[3]);
		}
	}
	
	#endregion
	
	#region  第 6 组，5个参数。

	public partial class ActionWrapper<TTarget, A1, A2, A3, A4, A5> : ReflectMethodBase<InstanceAction<TTarget, A1, A2, A3, A4, A5>>
	{
		protected override void InvokeInternal(object target, object[] parameters)
		{
			_caller((TTarget)target, (A1)parameters[0], (A2)parameters[1], (A3)parameters[2], (A4)parameters[3], (A5)parameters[4]);
		}
	}

	public partial class StaticActionWrapper<A1, A2, A3, A4, A5> : ReflectMethodBase<StaticAction<A1, A2, A3, A4, A5>>
	{
		protected override void InvokeInternal(object target, object[] parameters)
		{
			_caller((A1)parameters[0], (A2)parameters[1], (A3)parameters[2], (A4)parameters[3], (A5)parameters[4]);
		}
	}

	public partial class FunctionWrapper<TTarget, A1, A2, A3, A4, A5, TResult> : ReflectMethodBase<InstanceFunc<TTarget, A1, A2, A3, A4, A5, TResult>>
	{
		protected override void InvokeInternal(object target, object[] parameters)
		{
			_returnValue = _caller((TTarget)target, (A1)parameters[0], (A2)parameters[1], (A3)parameters[2], (A4)parameters[3], (A5)parameters[4]);
		}
	}

	public partial class StaticFunctionWrapper<A1, A2, A3, A4, A5, TResult> : ReflectMethodBase<StaticFunc<A1, A2, A3, A4, A5, TResult>>
	{
		protected override void InvokeInternal(object target, object[] parameters)
		{
			_returnValue = _caller((A1)parameters[0], (A2)parameters[1], (A3)parameters[2], (A4)parameters[3], (A5)parameters[4]);
		}
	}
	
	#endregion


	#region  第 7 组，6个参数。 这一组不实现Action方法的优化。

	public partial class FunctionWrapper<TTarget, A1, A2, A3, A4, A5, A6, TResult> 
: ReflectMethodBase<InstanceFunc<TTarget, A1, A2, A3, A4, A5, A6, TResult>>
	{
		protected override void InvokeInternal(object target, object[] parameters)
		{
			_returnValue = _caller((TTarget)target, (A1)parameters[0], (A2)parameters[1], (A3)parameters[2], (A4)parameters[3], 
				(A5)parameters[4], (A6)parameters[5]);
		}
	}

	public partial class StaticFunctionWrapper<A1, A2, A3, A4, A5, A6, TResult> 
		: ReflectMethodBase<StaticFunc<A1, A2, A3, A4, A5, A6, TResult>>
	{
		protected override void InvokeInternal(object target, object[] parameters)
		{
			_returnValue = _caller((A1)parameters[0], (A2)parameters[1], (A3)parameters[2], (A4)parameters[3],
				(A5)parameters[4], (A6)parameters[5]);
		}
	}

	#endregion

	#region  第 8 组，7个参数。 这一组不实现Action方法的优化。

	public partial class FunctionWrapper<TTarget, A1, A2, A3, A4, A5, A6, A7, TResult>
: ReflectMethodBase<InstanceFunc<TTarget, A1, A2, A3, A4, A5, A6, A7, TResult>>
	{
		protected override void InvokeInternal(object target, object[] parameters)
		{
			_returnValue = _caller((TTarget)target, (A1)parameters[0], (A2)parameters[1], (A3)parameters[2], (A4)parameters[3],
				(A5)parameters[4], (A6)parameters[5], (A7)parameters[6]);
		}
	}

	public partial class StaticFunctionWrapper<A1, A2, A3, A4, A5, A6, A7, TResult>
		: ReflectMethodBase<StaticFunc<A1, A2, A3, A4, A5, A6, A7, TResult>>
	{
		protected override void InvokeInternal(object target, object[] parameters)
		{
			_returnValue = _caller((A1)parameters[0], (A2)parameters[1], (A3)parameters[2], (A4)parameters[3],
				(A5)parameters[4], (A6)parameters[5], (A7)parameters[6]);
		}
	}

	#endregion

	#region  第 9 组，8个参数。 这一组不实现Action方法的优化。

	public partial class FunctionWrapper<TTarget, A1, A2, A3, A4, A5, A6, A7, A8, TResult>
: ReflectMethodBase<InstanceFunc<TTarget, A1, A2, A3, A4, A5, A6, A7, A8, TResult>>
	{
		protected override void InvokeInternal(object target, object[] parameters)
		{
			_returnValue = _caller((TTarget)target, (A1)parameters[0], (A2)parameters[1], (A3)parameters[2], (A4)parameters[3],
				(A5)parameters[4], (A6)parameters[5], (A7)parameters[6], (A8)parameters[7]);
		}
	}

	public partial class StaticFunctionWrapper<A1, A2, A3, A4, A5, A6, A7, A8, TResult>
		: ReflectMethodBase<StaticFunc<A1, A2, A3, A4, A5, A6, A7, A8, TResult>>
	{
		protected override void InvokeInternal(object target, object[] parameters)
		{
			_returnValue = _caller((A1)parameters[0], (A2)parameters[1], (A3)parameters[2], (A4)parameters[3],
				(A5)parameters[4], (A6)parameters[5], (A7)parameters[6], (A8)parameters[7]);
		}
	}

	#endregion

	#region  第 10 组，9个参数。 这一组不实现Action方法的优化。

	public partial class FunctionWrapper<TTarget, A1, A2, A3, A4, A5, A6, A7, A8, A9, TResult>
: ReflectMethodBase<InstanceFunc<TTarget, A1, A2, A3, A4, A5, A6, A7, A8, A9, TResult>>
	{
		protected override void InvokeInternal(object target, object[] parameters)
		{
			_returnValue = _caller((TTarget)target, (A1)parameters[0], (A2)parameters[1], (A3)parameters[2], (A4)parameters[3],
				(A5)parameters[4], (A6)parameters[5], (A7)parameters[6], (A8)parameters[7], (A9)parameters[8]);
		}
	}

	public partial class StaticFunctionWrapper<A1, A2, A3, A4, A5, A6, A7, A8, A9, TResult>
		: ReflectMethodBase<StaticFunc<A1, A2, A3, A4, A5, A6, A7, A8, A9, TResult>>
	{
		protected override void InvokeInternal(object target, object[] parameters)
		{
			_returnValue = _caller((A1)parameters[0], (A2)parameters[1], (A3)parameters[2], (A4)parameters[3],
				(A5)parameters[4], (A6)parameters[5], (A7)parameters[6], (A8)parameters[7], (A9)parameters[8]);
		}
	}

	#endregion


	#region 其它的强类型方法，用于频繁调用某一个特定方法。可视情况自行添加，例如：

	public partial class ActionWrapper<TTarget>
	{
		public void Call(TTarget target)
		{
			_caller(target);
		}
	}

	public partial class ActionWrapper<TTarget, A1>
	{
		public void Call(TTarget target, A1 a1)
		{
			_caller(target, a1);
		}
	}

	public partial class FunctionWrapper<TTarget, A1, TResult>
	{
		public TResult Call(TTarget target, A1 a1)
		{
			return _caller(target, a1);
		}
	}

	public partial class ActionWrapper<TTarget, A1, A2> 
	{
		public void Call(TTarget target, A1 a1, A2 a2)
		{
			_caller(target, a1, a2);
		}
	}

	public partial class FunctionWrapper<TTarget, A1, A2, TResult>
	{
		public TResult Call(TTarget target, A1 a1, A2 a2)
		{
			return _caller(target, a1, a2);
		}
	}

	public partial class ActionWrapper<TTarget, A1, A2, A3>
	{
		public void Call(TTarget target, A1 a1, A2 a2, A3 a3)
		{
			_caller(target, a1, a2, a3);
		}
	}

	public partial class FunctionWrapper<TTarget, A1, A2, A3, TResult>
	{
		public TResult Call(TTarget target, A1 a1, A2 a2, A3 a3)
		{
			return _caller(target, a1, a2, a3);
		}
	}

	#endregion

}

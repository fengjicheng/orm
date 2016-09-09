using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;
using System.Collections;


//-------------------------------------------------------------
// 代码来源于Fish Li的博客示例，博客网址：
//		http://www.cnblogs.com/fish-li/archive/2013/02/18/2916253.html

// 使用方法

// 1. 先引用命名空间： using OptimizeReflection;

// 2. 参考下面的代码调用 FastSetValue(...) 或者 FastGetValue(...)

/*
	Type instanceType = typeof(DemoClass);
	PropertyInfo propertyInfo = instanceType.GetProperty("Id");

	// 写属性
	propertyInfo.FastSetValue(obj, 123);

	// 读属性
	int a = (int)propertyInfo.FastGetValue(obj);
*/
//-------------------------------------------------------------


namespace Qhyhgf.WeiXin.Qy.Api.Dynamic
{
	/// <summary>
	/// 定义读属性操作的接口
	/// </summary>
	public interface IGetValue
	{
		object Get(object target);
	}
	/// <summary>
	/// 定义写属性操作的接口
	/// </summary>
	public interface ISetValue
	{
		void Set(object target, object val);
	}


	/// <summary>
	/// 创建IGetValue或者ISetValue实例的工厂方法类
	/// </summary>
	public static class GetterSetterFactory
	{
		private static readonly Hashtable s_getterDict = Hashtable.Synchronized(new Hashtable(10240));
		private static readonly Hashtable s_setterDict = Hashtable.Synchronized(new Hashtable(10240));

		internal static IGetValue GetPropertyGetterWrapper(PropertyInfo propertyInfo)
		{
			IGetValue property = (IGetValue)s_getterDict[propertyInfo];
			if( property == null ) {
				property = CreatePropertyGetterWrapper(propertyInfo);
				s_getterDict[propertyInfo] = property;
			}
			return property;
		}

		internal static ISetValue GetPropertySetterWrapper(PropertyInfo propertyInfo)
		{
			ISetValue property = (ISetValue)s_setterDict[propertyInfo];
			if( property == null ) {
				property = CreatePropertySetterWrapper(propertyInfo);
				s_setterDict[propertyInfo] = property;
			}
			return property;
		}

		/// <summary>
		/// 根据指定的PropertyInfo对象，返回对应的IGetValue实例
		/// </summary>
		/// <param name="propertyInfo"></param>
		/// <returns></returns>
		public static IGetValue CreatePropertyGetterWrapper(PropertyInfo propertyInfo)
		{
			if( propertyInfo == null )
				throw new ArgumentNullException("propertyInfo");
			if( propertyInfo.CanRead == false )
				throw new InvalidOperationException("属性不支持读操作。");

			MethodInfo mi = propertyInfo.GetGetMethod(true);

			if( mi.GetParameters().Length > 0 )
				throw new NotSupportedException("不支持构造索引器属性的委托。");
			
			if( mi.IsStatic ) {
				Type instanceType = typeof(StaticGetterWrapper<>).MakeGenericType(propertyInfo.PropertyType);
				return (IGetValue)Activator.CreateInstance(instanceType, propertyInfo);
			}
			else {
				Type instanceType = typeof(GetterWrapper<,>).MakeGenericType(propertyInfo.DeclaringType, propertyInfo.PropertyType);
				return (IGetValue)Activator.CreateInstance(instanceType, propertyInfo);
			}
		}

		/// <summary>
		/// 根据指定的PropertyInfo对象，返回对应的ISetValue实例
		/// </summary>
		/// <param name="propertyInfo"></param>
		/// <returns></returns>
		public static ISetValue CreatePropertySetterWrapper(PropertyInfo propertyInfo)
		{
			if( propertyInfo == null )
				throw new ArgumentNullException("propertyInfo");
			if( propertyInfo.CanWrite == false )
				throw new NotSupportedException("属性不支持写操作。");

			MethodInfo mi = propertyInfo.GetSetMethod(true);

			if( mi.GetParameters().Length > 1 )
				throw new NotSupportedException("不支持构造索引器属性的委托。");

			if( mi.IsStatic ) {
				Type instanceType = typeof(StaticSetterWrapper<>).MakeGenericType(propertyInfo.PropertyType);
				return (ISetValue)Activator.CreateInstance(instanceType, propertyInfo);
			}
			else {
				Type instanceType = typeof(SetterWrapper<,>).MakeGenericType(propertyInfo.DeclaringType, propertyInfo.PropertyType);
				return (ISetValue)Activator.CreateInstance(instanceType, propertyInfo);
			}
		}
	}

	/// <summary>
	/// 一些扩展方法，用于访问属性，它们都可以优化反射性能。
	/// </summary>
	public static class PropertyExtensions
	{
		/// <summary>
		/// 快速调用PropertyInfo的GetValue方法
		/// </summary>
		/// <param name="propertyInfo"></param>
		/// <param name="obj"></param>
		/// <returns></returns>
		public static object FastGetValue(this PropertyInfo propertyInfo, object obj)
		{
			if( propertyInfo == null )
				throw new ArgumentNullException("propertyInfo");

			return GetterSetterFactory.GetPropertyGetterWrapper(propertyInfo).Get(obj);
		}

		/// <summary>
		/// 快速调用PropertyInfo的SetValue方法
		/// </summary>
		/// <param name="propertyInfo"></param>
		/// <param name="obj"></param>
		/// <param name="value"></param>
		public static void FastSetValue(this PropertyInfo propertyInfo, object obj, object value)
		{
			if( propertyInfo == null )
				throw new ArgumentNullException("propertyInfo");

			GetterSetterFactory.GetPropertySetterWrapper(propertyInfo).Set(obj, value);
		}
	}

	public class GetterWrapper<TTarget, TValue> : IGetValue
	{
		private Func<TTarget, TValue> _getter;

		public GetterWrapper(PropertyInfo propertyInfo)
		{
			if( propertyInfo == null )
				throw new ArgumentNullException("propertyInfo");

			if( propertyInfo.CanRead == false )
				throw new InvalidOperationException("属性不支持读操作。");

			MethodInfo m = propertyInfo.GetGetMethod(true);
			_getter = (Func<TTarget, TValue>)Delegate.CreateDelegate(typeof(Func<TTarget, TValue>), null, m);
		}
		
		public TValue GetValue(TTarget target)
		{
			return _getter(target);
		}
		object IGetValue.Get(object target)
		{
			return _getter((TTarget)target);
		}
	}

	public class SetterWrapper<TTarget, TValue> : ISetValue
	{
		private Action<TTarget, TValue> _setter;

		public SetterWrapper(PropertyInfo propertyInfo)
		{
			if( propertyInfo == null )
				throw new ArgumentNullException("propertyInfo");

			if( propertyInfo.CanWrite == false )
				throw new NotSupportedException("属性不支持写操作。");

			MethodInfo m = propertyInfo.GetSetMethod(true);
			_setter = (Action<TTarget, TValue>)Delegate.CreateDelegate(typeof(Action<TTarget, TValue>), null, m);
		}
		
		public void SetValue(TTarget target, TValue val)
		{
			_setter(target, val);
		}
		void ISetValue.Set(object target, object val)
		{
			_setter((TTarget)target, (TValue)val);
		}
	}


	public class StaticGetterWrapper<TValue> : IGetValue
	{
		private Func<TValue> _getter;

		public StaticGetterWrapper(PropertyInfo propertyInfo)
		{
			if( propertyInfo == null )
				throw new ArgumentNullException("propertyInfo");

			if( propertyInfo.CanRead == false )
				throw new InvalidOperationException("属性不支持读操作。");

			MethodInfo m = propertyInfo.GetGetMethod(true);
			_getter = (Func<TValue>)Delegate.CreateDelegate(typeof(Func<TValue>), m);
		}

		public TValue GetValue()
		{
			return _getter();
		}
		object IGetValue.Get(object target)
		{
			return _getter();
		}
	}

	public class StaticSetterWrapper<TValue> : ISetValue
	{
		private Action<TValue> _setter;

		public StaticSetterWrapper(PropertyInfo propertyInfo)
		{
			if( propertyInfo == null )
				throw new ArgumentNullException("propertyInfo");

			if( propertyInfo.CanWrite == false )
				throw new NotSupportedException("属性不支持写操作。");

			MethodInfo m = propertyInfo.GetSetMethod(true);
			_setter = (Action<TValue>)Delegate.CreateDelegate(typeof(Action<TValue>), m);
		}

		public void SetValue(TValue val)
		{
			_setter(val);
		}
		void ISetValue.Set(object target, object val)
		{
			_setter((TValue)val);
		}
	}
}

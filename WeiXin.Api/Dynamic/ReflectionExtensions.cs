using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Reflection;

namespace Qhyhgf.WeiXin.Qy.Api.Dynamic
{

	/// <summary>
	/// 一些扩展方法，用于反射操作，它们都可以优化反射性能。
	/// </summary>
	public static class ReflectionExtensions
	{
		private static readonly Hashtable s_getterDict = Hashtable.Synchronized(new Hashtable(10240));
		private static readonly Hashtable s_setterDict = Hashtable.Synchronized(new Hashtable(10240));
		private static readonly Hashtable s_methodDict = Hashtable.Synchronized(new Hashtable(10240));


		public static object FastGetValue(this FieldInfo fieldInfo, object obj)
		{
			if( fieldInfo == null )
				throw new ArgumentNullException("fieldInfo");

			GetValueDelegate getter = (GetValueDelegate)s_getterDict[fieldInfo];
			if( getter == null ) {
				getter = DynamicMethodFactory.CreateFieldGetter(fieldInfo);
				s_getterDict[fieldInfo] = getter;
			}

			return getter(obj);
		}

		public static void FastSetField(this FieldInfo fieldInfo, object obj, object value)
		{
			if( fieldInfo == null )
				throw new ArgumentNullException("fieldInfo");

			SetValueDelegate setter = (SetValueDelegate)s_setterDict[fieldInfo];
			if( setter == null ) {
				setter = DynamicMethodFactory.CreateFieldSetter(fieldInfo);
				s_setterDict[fieldInfo] = setter;
			}

			setter(obj, value);
		}


		public static object FastNew(this Type instanceType)
		{
			if( instanceType == null )
				throw new ArgumentNullException("instanceType");

			CtorDelegate ctor = (CtorDelegate)s_methodDict[instanceType];
			if( ctor == null ) {
				ConstructorInfo ctorInfo = instanceType.GetConstructor(Type.EmptyTypes);
				ctor = DynamicMethodFactory.CreateConstructor(ctorInfo);
				s_methodDict[instanceType] = ctor;
			}

			return ctor();
		}




		public static object FastGetValue2(this PropertyInfo propertyInfo, object obj)
		{
			if( propertyInfo == null )
				throw new ArgumentNullException("propertyInfo");

			GetValueDelegate getter = (GetValueDelegate)s_getterDict[propertyInfo];
			if( getter == null ) {
				getter = DynamicMethodFactory.CreatePropertyGetter(propertyInfo);
				s_getterDict[propertyInfo] = getter;
			}

			return getter(obj);
		}

		public static void FastSetValue2(this PropertyInfo propertyInfo, object obj, object value)
		{
			if( propertyInfo == null )
				throw new ArgumentNullException("propertyInfo");

			SetValueDelegate setter = (SetValueDelegate)s_setterDict[propertyInfo];
			if( setter == null ) {
				setter = DynamicMethodFactory.CreatePropertySetter(propertyInfo);
				s_setterDict[propertyInfo] = setter;
			}

			setter(obj, value);
		}


		public static object FastInvoke2(this MethodInfo methodInfo, object obj, params object[] parameters)
		{
			if( methodInfo == null )
				throw new ArgumentNullException("methodInfo");

			MethodDelegate invoker = (MethodDelegate)s_methodDict[methodInfo];
			if( invoker == null ) {
				invoker = DynamicMethodFactory.CreateMethod(methodInfo);
				s_methodDict[methodInfo] = invoker;
			}

			return invoker(obj, parameters);
		}
	}
}

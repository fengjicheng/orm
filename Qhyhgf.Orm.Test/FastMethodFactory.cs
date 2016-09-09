using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

namespace Qhyhgf.Test
{
    public delegate void SetValueDelegate(object target, object arg);
    public static  class FastMethodFactory
    {
        public static SetValueDelegate CreatePropertySetter(PropertyInfo property)
        {
            if (property == null)
            {
                throw new ArgumentException("property");
            }
            //如果属性不可读取
            if (!property.CanRead)
            {
                return null;
            }
            MethodInfo setMethod = property.GetSetMethod(true);
            DynamicMethod dm = new DynamicMethod("PropertySetter", null,
                new Type[] { typeof(object), typeof(object) },
            property.DeclaringType, true);
            ILGenerator il = dm.GetILGenerator();
            if (!setMethod.IsStatic)
            {
                il.Emit(OpCodes.Ldarg_0);
            }
            il.Emit(OpCodes.Ldarg_1);
            if (!setMethod.IsStatic && !property.DeclaringType.IsValueType)
            {
                il.EmitCall(OpCodes.Callvirt, setMethod, null);
            }
            else
                il.EmitCall(OpCodes.Call, setMethod, null);

            il.Emit(OpCodes.Ret);

            return (SetValueDelegate)dm.CreateDelegate(typeof(SetValueDelegate));

        }
        private static void EmitCastToReference(ILGenerator il, Type type)
        {
            if (type.IsValueType)
                il.Emit(OpCodes.Unbox_Any, type);
            else
                il.Emit(OpCodes.Castclass, type);
        }
    }
}

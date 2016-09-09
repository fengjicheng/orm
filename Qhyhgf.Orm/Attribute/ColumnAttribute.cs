/*----------------------------------------------------------------
 * 作者：冯际成
 * 时间：2016年9月5日
 * ----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qhyhgf.Orm.Attribute
{

    /// <summary>
    ///  指定该属性是否是Table中的主键
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class ColumnAttribute : System.Attribute
    {
        /// <summary>
        /// 是否是主键
        /// </summary>
        public bool IsPrimary { get; set;}
        /// <summary>
        /// 名字
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// <para>在加载数据时，不加载这个成员。</para>
        /// <para>注意：如果数据结果中不包含匹配的字段，对应的数据成员也不会被加载。</para>
        /// </summary>
        public bool IgnoreLoad
        {
            get;
            set;
        }
        /// <summary>
        ///构造函数
        /// </summary>
        public ColumnAttribute()
        {
            ///默认加载吃成员
            IgnoreLoad = true;
        }

    }
}

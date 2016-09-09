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
    /// 指定Model所对应的视图名称
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class ViewAttribute : System.Attribute
    {
        /// <summary>
        /// 视图的名称
        /// </summary>
        private string _viewname = string.Empty;
        /// <summary>
        /// 映射为视图的名称
        /// </summary>
        public string ViewName
        {
            get { return _viewname; }
            set { _viewname = value; }
        }
        public ViewAttribute()
        {
        }
    }
}

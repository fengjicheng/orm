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
    /// 指定Model所对应的Table名称
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class TableAttribute :System.Attribute
    {
        /// <summary>
        /// 表的名称
        /// </summary>
        private string _tablename = string.Empty;
        /// <summary>
        /// 映射为表的名称
        /// </summary>
        public string TableName
        {
            get { return _tablename; }
            set { _tablename = value; }
        }
        public TableAttribute()
        {
        }
    }
}

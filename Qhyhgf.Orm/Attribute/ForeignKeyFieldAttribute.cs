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
    /// 外键Attribute定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class ForeignKeyFieldAttribute : System.Attribute
    {
        public ForeignKeyFieldAttribute(string columnName)
        {
            this.ColumnName = columnName;
        }
        /// <summary>
        /// 外表的名称
        /// </summary>
        public Type SourceTableName { get; set; }
        public string ColumnName { get; set; }

        public string TableName { get; set; }
    }
}

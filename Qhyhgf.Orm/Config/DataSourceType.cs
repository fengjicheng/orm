using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qhyhgf.Orm.Config
{
    /// <summary>
    /// 数据库类型
    /// </summary>
    [Flags]
    public enum DataSourceType
    {
        /// <summary>
        /// SqlServer
        /// </summary>
        SqlServer = 1 << 0,
        /// <summary>
        /// Orcal
        /// </summary>
        Oracl = 1 << 1,
        /// <summary>
        /// Access
        /// </summary>
        Access = 1 << 2,
        /// <summary>
        /// MySql
        /// </summary>
        MysSql = 1 << 3,
        SqlLite = 1 << 4,
    }
}

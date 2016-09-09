using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qhyhgf.Orm.Config
{
    /// <summary>
    ///定义每个数据库可以读写分离操作
    /// </summary>
    [Flags]
    internal enum ActionType
    {
        /// <summary>
        /// 读操作         
        /// </summary>
        Read  = 1  << 0,
        /// <summary>
        /// 写操作
        /// </summary>
        Write = 1 << 1,
        /// <summary>
        /// 所有动作
        /// </summary>
        All = 1 << 2
    }
}

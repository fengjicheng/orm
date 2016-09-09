using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qhyhgf.Orm
{
    /// <summary>
    /// 表示要执行什么类型的命令
    /// </summary>
    public enum CommandKind
    {
        /// <summary>
        /// 表示要执行一个存储过程
        /// </summary>
        StoreProcedure,
        /// <summary>
        /// 表示要执行一条没有参数的SQL语句
        /// </summary>
        SqlTextNoParams,
        /// <summary>
        /// 表示要执行一条包含参数的SQL语句
        /// </summary>
        SqlTextWithParams
    }
}

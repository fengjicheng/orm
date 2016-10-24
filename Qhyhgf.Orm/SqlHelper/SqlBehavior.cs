using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;
using System.Data.Sql;
namespace Qhyhgf.Orm.SqlHelper
{
    /// <summary>
    /// 查询接口
    /// </summary>
    public interface SqlBehavior
    {
        /// <summary>
        /// 获取设置查询字符串
        /// </summary>
        DbConnection Connection { get; set; }
        /// <summary>
        /// 执行sql语句反会相应条数
        /// </summary>
        /// <param name="commandType">命令类型</param>
        /// <param name="commandText">字符串</param>
        /// <returns>响应行数</returns>
        int ExecuteNonQuery(CommandType commandType, string commandText);
        /// <summary>
        /// Command Object
        /// </summary>
        DbCommand Command { get; set; }

    }
}

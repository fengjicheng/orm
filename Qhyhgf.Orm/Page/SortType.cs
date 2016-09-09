/*----------------------------------------------------------------
 * 作者：冯际成
 * 时间：2016年9月5日
 * ----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qhyhgf.Orm.Page
{
    /// <summary>
    /// 排序方式
    /// </summary>
    [Flags]
    public enum SortType
    {
        /// <summary>
        /// 升序
        /// </summary>
        ASC = 1 << 0,
        /// <summary>
        /// 降序
        /// </summary>
        DESC = 1 << 1
      
    }
}

/*----------------------------------------------------------------
 * 作者：冯际成
 * 时间：2016年9月5日
 * ----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qhyhgf.Orm
{
    /// <summary>
    /// 编译数据实体加载器代码发生异常的事件委托
    /// </summary>
    /// <param name="ex">异常对象</param>
    public delegate void BuildExceptionHandler(OrmException ex);
}

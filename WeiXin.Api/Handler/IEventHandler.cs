using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Qhyhgf.WeiXin.Qy.Api.Handler
{
    public interface IEventHandler
    {
        /// <summary>
        /// 执行并返回结果
        /// </summary>
        /// <param name="context">微信服务器发过来的xml消息</param>
        /// <returns>处理结果</returns>
        string Execute(string context);
    }
}

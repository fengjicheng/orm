using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Qhyhgf.WeiXin.Qy.Api.Token;

namespace Qhyhgf.WeiXin.Qy.Api
{
    public interface IWeiXinClient
    {
        /// <summary>
        /// 认证信息.
        /// </summary>
        TokenEntity Token { get; set; }
        /// <summary>
        /// 执行WeiXin公开API请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的TOP API请求</param>
        /// <returns>领域对象</returns>
        T Execute<T>(IWeiXinRequest<T> request) where T : WeiXinResponse;
    }
}

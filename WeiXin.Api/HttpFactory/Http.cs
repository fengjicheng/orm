using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Qhyhgf.WeiXin.Qy.Api.Attribute;
using Qhyhgf.WeiXin.Qy.Api.Token;

namespace Qhyhgf.WeiXin.Qy.Api.HttpFactory
{
    /// <summary>
    /// Http请求
    /// </summary>
    public class Http<T> where T : WeiXinResponse
    {
        public HttpMethodAttribute HttpMethodAttribute { get; set; }
        public TokenEntity Token { get; set; }
        /// <summary>
        /// Request参数
        /// </summary>
        public IWeiXinRequest<T> Request{ get; set; }//第一个数
        /// <summary>
        /// 获得Response返回信息.
        /// </summary>
        /// <returns></returns>
        public virtual T GetResponse()
        {
            T obj=default(T);
            return obj;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using Qhyhgf.WeiXin.Qy.Api.Helpers;
using Qhyhgf.WeiXin.Qy.Api.Attribute;
using Qhyhgf.WeiXin.Qy.Api.Config;
using Qhyhgf.WeiXin.Qy.Api.HttpFactory;
using Qhyhgf.WeiXin.Qy.Api.Token;

namespace Qhyhgf.WeiXin.Qy.Api
{
    public class DefaultWeiXinClient : IWeiXinClient
    {
        private TokenEntity _Token;
        /// <summary>
        /// 身份标示。
        /// </summary>
        public TokenEntity Token
        {
            get
            {
                return _Token;
            }
            set
            {
                _Token = value;
            }
        }
        /// <summary>
        /// 执行方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public T Execute<T>(IWeiXinRequest<T> request) where T : WeiXinResponse
        {
            //获得httpMethodAttribute数据.
            Type info = request.GetType();
            var HttpAttributeInfo = (HttpMethodAttribute)System.Attribute.GetCustomAttribute(info, typeof(HttpMethodAttribute));
            ///根据不同的请求方式
            Http<T> http = HttpFactory<T>.CreateHttp(HttpAttributeInfo.Method);
            //延签消息
            http.Token = Token;
            http.HttpMethodAttribute = HttpAttributeInfo;
            http.Request = request;
            return http.GetResponse();
        }
    }
}

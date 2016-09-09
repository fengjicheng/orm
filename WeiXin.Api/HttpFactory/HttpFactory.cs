using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Qhyhgf.WeiXin.Qy.Api.Attribute;

namespace Qhyhgf.WeiXin.Qy.Api.HttpFactory
{
    /// <summary>
    /// Http请求工厂
    /// </summary>
    public class HttpFactory<T> where T : WeiXinResponse
    {
        public static Http<T> CreateHttp(HttpVerb Method)
        {
             Http<T> http = null;
             switch (Method)
             {
                 //get请求
                 case HttpVerb.Get:
                     http = new HttpGet<T>();
                     break;
                 //post请求
                 case HttpVerb.Post:
                     http = new HttpPost<T>();
                     break;
                 //上传文件
                 case HttpVerb.File:
                     http = new HttpFile<T>();
                     break;
             }
             return http;
        }
    }
}

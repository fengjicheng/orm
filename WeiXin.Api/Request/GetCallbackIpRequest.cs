using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Qhyhgf.WeiXin.Qy.Api.Attribute;
using System.Runtime.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Response;

namespace Qhyhgf.WeiXin.Qy.Api.Request
{
    /// <summary>
    /// 获取微信服务器的ip段
    /// </summary>
    [Serializable]
    [DataContract]
    [HttpMethod(Method = HttpVerb.Get, Url = "https://qyapi.weixin.qq.com/cgi-bin/getcallbackip", Name = "获取微信服务器的ip段", IsToken = true, Serialize = SerializeVerb.Json)]
    public class GetCallbackIpRequest : IWeiXinRequest<GetCallbackIpResponse>
    {
    }
}

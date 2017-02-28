using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Qhyhgf.WeiXin.Qy.Api.Attribute;
using Qhyhgf.WeiXin.Qy.Api.Response;

namespace Qhyhgf.WeiXin.Qy.Api.Request
{
    [Serializable]
    [DataContract]
    [HttpMethod(Method = HttpVerb.Get, Url = "https://qyapi.weixin.qq.com/cgi-bin/get_jsapi_ticket", Name = "获得jsapi_ticket", IsToken = true, Serialize = SerializeVerb.Json)]
    public class GetJsapiTicketRequest : IWeiXinRequest<GetJsapiTicketResponse>
    {
    }
}

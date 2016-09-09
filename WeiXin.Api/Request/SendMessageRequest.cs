using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Qhyhgf.WeiXin.Qy.Api.Response;
using Qhyhgf.WeiXin.Qy.Api.Attribute;
using System.Runtime.Serialization;
using Qhyhgf.WeiXin.Qy.Api.SeedMessage;

namespace Qhyhgf.WeiXin.Qy.Api.Request
{
    /// <summary>
    /// 主动发送消息
    /// </summary>
    [Serializable]
    [DataContract]
    [HttpMethod(Method = HttpVerb.Post, Url = "https://qyapi.weixin.qq.com/cgi-bin/message/send", Name = "主动发送消息", IsToken = true, Serialize = SerializeVerb.Json)]
    public class SendMessageRequest :BaseMessage,IWeiXinRequest<SendMessageResponse>
    {
    }
}

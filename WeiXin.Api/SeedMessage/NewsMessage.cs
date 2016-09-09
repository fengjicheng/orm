using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Request;
using Qhyhgf.WeiXin.Qy.Api.Attribute;

namespace Qhyhgf.WeiXin.Qy.Api.SeedMessage
{
    /// <summary>
    /// 图文消息
    /// </summary>
    [HttpMethod(Method = HttpVerb.Post, Url = "https://qyapi.weixin.qq.com/cgi-bin/message/send", Name = "主动发送消息", IsToken = true, Serialize = SerializeVerb.Json)]
    public class NewsMessage : SendMessageRequest
    {
        public NewsMessage()
        {
            MsgType = Domain.MessageType.News;
            News = new NewsList();
        }
        /// <summary>
        /// 图片内容
        /// </summary>
        [DataMember(Name = "news")]
        public NewsList News { get; set; }
    }
}

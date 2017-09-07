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
    /// 文本卡片消息
    /// </summary>
    [HttpMethod(Method = HttpVerb.Post, Url = "https://qyapi.weixin.qq.com/cgi-bin/message/send", Name = "主动发送消息", IsToken = true, Serialize = SerializeVerb.Json)]
    public class TextCardMessageRequest : SendMessageRequest
    {
        public TextCardMessageRequest()
        {
            MsgType = Domain.MessageType.TextCard;
            TextCard = new TextCardEntity();
        }
        /// <summary>
        /// 文件内容
        /// </summary>
        [DataMember(Name = "textcard")]
        public TextCardEntity TextCard { get; set; }
    }
}

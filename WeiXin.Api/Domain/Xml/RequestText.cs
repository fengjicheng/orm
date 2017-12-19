using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Helpers;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    /// <summary>
    /// 被动响应text消息
    /// </summary>
    [Serializable]
    [XmlRoot("xml")]
    public class RequestText : BaseMessage
    {
        public RequestText()
        {
            //消息类型
            MsgType = new CDATA<MessageType>(MessageType.Text);
            //消息发送时间
            CreateTime = DateTime.Now.ConvertToTimeStamp();
        }
        /// <summary>
        /// 文本消息内
        /// </summary>
        [XmlElement("Content")]
        public CDATA<string> Content { get; set; }
    }
}

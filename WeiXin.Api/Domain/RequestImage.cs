using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Helpers;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    /// <summary>
    /// 被动响应image消息
    /// </summary>
    [Serializable]
    [XmlRoot("xml")]
    public class RequestVideo : BaseMessage
    {
        public RequestVideo()
        {
            //消息类型
            MsgType = new CDATA<MessageType>(MessageType.Video);
            //消息发送时间
            CreateTime = DateTime.Now.ConvertToTimeStamp();
            Video = new MediaVideoEntity();
        }
        /// <summary>
        /// 视频消息
        /// </summary>
        [XmlElement("Video")]
        public MediaVideoEntity Video { get; set; }
    }
}

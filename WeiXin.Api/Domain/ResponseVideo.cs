using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Helpers;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    /// <summary>
    /// Video消息
    /// </summary>
    [Serializable]
    [XmlRoot("xml")]
    public class ResponseVideo : BaseMessage
    {
        /// <summary>
        /// 消息id，64位整型
        /// </summary>
        [XmlElement("MediaId")]
        public CDATA<string> MediaId { get; set; }
        /// <summary>
        /// 视频消息缩略图的媒体id，可以调用获取媒体文件接口拉取数据
        /// </summary>
        [XmlElement("ThumbMediaId")]
        public CDATA<string> ThumbMediaId { get; set; }
        /// <summary>
        /// 消息id，64位整型
        /// </summary>
        [XmlElement("MsgId")]
        public long MsgId { get; set; }
        /// <summary>
        /// 企业应用的id，整型。可在应用的设置页面查看
        /// </summary>
        [XmlElement("AgentID")]
        public int AgentID { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Helpers;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    /// <summary>
    /// image消息
    /// </summary>
    [Serializable]
    [XmlRoot("xml")]
    public class ResponseImage : BaseMessage
    {
        /// <summary>
        /// 图片链接
        /// </summary>
        [XmlElement("PicUrl")]
        public CDATA<string> PicUrl { get; set; }
        /// <summary>
        /// 消息id，64位整型
        /// </summary>
        [XmlElement("MediaId")]
        public CDATA<string> MediaId { get; set; }
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

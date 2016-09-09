using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Helpers;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    /// <summary>
    /// 消息基类
    /// </summary>
    [Serializable]
    [XmlRoot("xml")]
    public abstract class BaseMessage
    {
        /// <summary>
        /// 企业号CorpID
        /// </summary>
        [XmlElement("ToUserName")]
        public CDATA<string> ToUserName { get; set; }
        /// <summary>
        /// 员工UserID
        /// </summary>
        [XmlElement("FromUserName")]
        public CDATA<string> FromUserName { get; set; }
        /// <summary>
        /// 消息创建时间（整型）
        /// </summary>
        [XmlElement("CreateTime")]
        public long CreateTime { get; set; }
        /// <summary>
        ///消息类型
        /// </summary>
        [XmlElement("MsgType")]
        public CDATA<MessageType> MsgType { get; set; }
    }
}

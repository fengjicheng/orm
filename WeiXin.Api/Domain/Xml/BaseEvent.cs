using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Helpers;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    /// <summary>
    ///事件基类
    /// </summary>
    [Serializable]
    [XmlRoot("xml")]
    public class BaseEvent:BaseMessage
    {
        /// <summary>
        /// 事件类型
        /// </summary>
        [XmlElement("Event")]
        public CDATA<EventType> Event { get; set; }
        /// <summary>
        /// 企业应用的id，整型。可在应用的设置页面查看
        /// </summary>
        [XmlElement("AgentID")]
        public int AgentID { get; set; }
    }
}

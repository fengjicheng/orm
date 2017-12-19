using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Helpers;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{   
    /// <summary>
    /// 用户进入应用的事件推送
    /// </summary>
    [Serializable]
    [XmlRoot("xml")]
    public class EnterAgentEvent : BaseEvent
    {

        /// <summary>
        /// 事件KEY值，此事件该值为空
        /// </summary>
        [XmlElement("EventKey")]
        public CDATA<string> EventKey { get; set; } 
    }
}

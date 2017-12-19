using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Helpers;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    /// <summary>
    /// 点击菜单跳转链接的事件推送
    /// </summary>
    [Serializable]
    [XmlRoot("xml")]
    public class ViewEvent : BaseEvent
    {
        /// <summary>
        /// 事件KEY值，设置的跳转URL
        /// </summary>
        [XmlElement("EventKey")]
        public CDATA<string> EventKey { get; set; }
    }
}

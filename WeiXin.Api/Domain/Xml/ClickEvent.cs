using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Helpers;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    /// <summary>
    /// 点击菜单拉取消息的事件推送
    /// </summary>
    [Serializable]
    [XmlRoot("xml")]
    public class ClickEvent : BaseMessage
    {
        /// <summary>
        /// 事件KEY值，与自定义菜单接口中KEY值对应
        /// </summary>
        [XmlElement("EventKey")]
        public CDATA<string> EventKey { get; set; }
    }
}

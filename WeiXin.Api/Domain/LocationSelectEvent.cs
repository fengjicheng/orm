using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Helpers;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    /// <summary>
    /// 弹出地理位置选择器的事件推送
    /// </summary>
    [Serializable]
    [XmlRoot("xml")]
    public class LocationSelectEvent:BaseEvent
    {
        /// <summary>
        /// 事件KEY值，由开发者在创建菜单时设定
        /// </summary>
        [XmlElement("EventKey")]
        public CDATA<string> EventKey { get; set; }
        /// <summary>
        /// 发送的位置信息
        /// </summary>
         [XmlElement("SendLocationInfo")]
        public SendLocationInfoEntity SendLocationInfo { get; set; }
    }
}

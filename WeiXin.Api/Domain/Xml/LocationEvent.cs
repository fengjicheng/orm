using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    /// <summary>
    /// 上报地理位置事件
    /// </summary>
    [Serializable]
    [XmlRoot("xml")]
    public class LocationEvent : BaseMessage
    {
        /// <summary>
        /// 地理位置纬度
        /// </summary>
        [XmlElement("Latitude")]
        public string Latitude { set; get; }
        /// <summary>
        /// 地理位置经度
        /// </summary>
        [XmlElement("Longitude")]
        public string Longitude { set; get; }
        /// <summary>
        ///地理位置精度
        /// </summary>
        [XmlElement("Precision")]
        public string Precision { set; get; }
    }
}

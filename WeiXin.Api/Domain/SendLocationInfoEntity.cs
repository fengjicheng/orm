using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Helpers;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    [Serializable]
    public class SendLocationInfoEntity
    {
        /// <summary>
        /// X坐标信息
        /// </summary>
        [XmlElement("Location_X")]
        public CDATA<string> LocationX { get; set; }
        /// <summary>
        /// Y坐标信息
        /// </summary>
        [XmlElement("Location_Y")]
        public CDATA<string> LocationY { get; set; }
        /// <summary>
        /// 精度，可理解为精度或者比例尺、越精细的话 scale越高
        /// </summary>
        [XmlElement("Scale")]
        public CDATA<string> Scale { get; set; }
        /// <summary>
        /// 地理位置的字符串信息
        /// </summary>
        [XmlElement("Label")]
        public CDATA<string> Label { get; set; }
        [XmlElement("Poiname")]
        public CDATA<string> Poiname { get; set; }
    }
}

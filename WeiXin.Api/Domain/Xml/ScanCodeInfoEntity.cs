using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Helpers;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    /// <summary>
    /// 扫描信息
    /// </summary>
    [Serializable]
    [XmlRoot("ScanCodeInfo")]
    public class ScanCodeInfoEntity
    {
        /// <summary>
        /// 扫描类型，一般是qrcode
        /// </summary>
        [XmlElement("ScanType")]
        public CDATA<string> ScanType { get; set; }
        /// <summary>
        /// 扫描结果，即二维码对应的字符串信息
        /// </summary>
        [XmlElement("ScanResult")]
        public CDATA<string> ScanResult { get; set; }

    }
}

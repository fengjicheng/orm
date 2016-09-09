using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Helpers;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    [Serializable]
    [XmlRoot("xml")]
    public class PicItemEntity
    {
        /// <summary>
        /// 图片的MD5值，开发者若需要，可用于验证接收到图片
        /// </summary>
        [XmlElement("PicMd5Sum")]
        public CDATA<string> PicMd5Sum { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Helpers;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    [Serializable]
    public class MediaEntity
    {
        /// <summary>
        /// 多媒体id，可以调用上传媒体文件接口获取
        /// </summary>
        [XmlElement("MediaId")]
        public CDATA<string> MediaId { get; set; }
    }
}

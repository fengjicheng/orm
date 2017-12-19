using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    /// <summary>
    /// 发送的图片信息
    /// </summary>
    [Serializable]
    [XmlRoot("xml")]
    public class SendPicsInfoEntity
    {
        [XmlElement("EventKey")]
        public int Count { get; set; }
        /// <summary>
        /// 图片列表
        /// </summary>
       // [XmlElement("PicList")]
        [XmlArray("PicList")]
        [XmlArrayItem("item")]
        public List<PicItemEntity> PicList { get; set; }
    }
}

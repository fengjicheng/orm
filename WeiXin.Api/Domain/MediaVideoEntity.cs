using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Helpers;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    [Serializable]
    public  class MediaVideoEntity
    {
        /// <summary>
        /// 多媒体id，可以调用上传媒体文件接口获取
        /// </summary>
        [XmlElement("MediaId")]
        public CDATA<string> MediaId { get; set; }
        /// <summary>
        /// 视频消息的标题
        /// </summary>
        [XmlElement("Title")]
        public CDATA<string> Title { get; set; }
        /// <summary>
        /// 视频消息的描述
        /// </summary>
        [XmlElement("Description")]
        public CDATA<string> Description { get; set; }
    }
}

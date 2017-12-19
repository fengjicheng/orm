using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Helpers;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    [Serializable]
    public class PicEntity
    {
        /// <summary>
        /// 图文消息标题
        /// </summary>
        [XmlElement("Title")]
        public CDATA<string> Title { get; set; }
        /// <summary>
        /// 图文消息描述
        /// </summary>
        [XmlElement("Description")]
        public CDATA<string> Description { get; set; }
        /// <summary>
        /// 图片链接，支持JPG、PNG格式，较好的效果为大图360*200，小图200*200
        /// </summary>
        [XmlElement("PicUrl")]
        public CDATA<string> PicUrl { get; set; }
        /// <summary>
        /// 点击图文消息跳转链接
        /// </summary>
        [XmlElement("Url")]
        public CDATA<string> Url { get; set; }

    }
}

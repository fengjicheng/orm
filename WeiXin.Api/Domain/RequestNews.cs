using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Helpers;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    /// <summary>
    /// 被动响应text消息
    /// </summary>
    [Serializable]
    [XmlRoot("xml")]
    public class RequestNews : BaseMessage
    {
        public RequestNews()
        {
            //消息类型
            MsgType = new CDATA<MessageType>(MessageType.News);
            //消息发送时间
            CreateTime = DateTime.Now.ConvertToTimeStamp();
            PicContent = new List<PicEntity>();
        }
        /// <summary>
        /// 图文条数，默认第一条为大图。图文数不能超过10，否则将会无响应
        /// </summary>
        [XmlElement("ArticleCount")]
        public int ArticleCount { get; set; }
        /// <summary>
        /// 文本消息内容
        /// </summary>
        [XmlArray("Articles")]
        [XmlArrayItem("item")]
        public List<PicEntity> PicContent { get; set; }
    }
}

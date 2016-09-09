using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.SeedMessage
{
    [Serializable]
    [DataContract]
    public class MpNewsEntity
    {
        /// <summary>
        /// 图文消息的标题
        /// </summary>
        [DataMember(Name = "title", IsRequired = true)]
        public string Title { get; set; }
        /// <summary>
        /// 图文消息缩略图的media_id, 可以在上传多媒体文件接口中获得。此处thumb_media_id即上传接口返回的media_id
        /// </summary>
        [DataMember(Name = "thumb_media_id", IsRequired = true)]
        public string ThumbMediaId { get; set; }
        /// <summary>
        /// 图文消息的作者
        /// </summary>
        [DataMember(Name = "author")]
        public string Author { get; set; }
        /// <summary>
        /// 图文消息点击“阅读原文”之后的页面链接
        /// </summary>
        [DataMember(Name = "content_source_url")]
        public string ContentSourceUrl { get; set; }
        /// <summary>
        /// 图文消息的内容，支持html标签
        /// </summary>
        [DataMember(Name = "content", IsRequired = true)]
        public string Content { get; set; }
        /// <summary>
        /// 图文消息的描述
        /// </summary>
        [DataMember(Name = "digest")]
        public string Digest { get; set; }
        /// <summary>
        /// 是否显示封面，1为显示，0为不显示
        /// </summary>
        [DataMember(Name = "show_cover_pic")]
        public string ShowCoverPic { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.SeedMessage
{
    [Serializable]
    [DataContract]
    public class VideoEntity
    {
        /// <summary>
        /// 视频媒体文件id，可以调用上传媒体文件接口获取
        /// </summary>
        [DataMember(Name = "media_id", IsRequired = true)]
        public string MediaId { get; set; }
        /// <summary>
        /// 视频消息的标题
        /// </summary>
        [DataMember(Name = "title")]
        public string Title { get; set; }
        /// <summary>
        /// 视频消息的描述
        /// </summary>
        [DataMember(Name = "description")]
        public string Description { get; set; }
    }
}

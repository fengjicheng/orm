using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Qhyhgf.WeiXin.Qy.Api.Domain;

namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    /// <summary>
    /// 上传多媒体
    /// </summary>
    public class MediaUploadResponse:WeiXinResponse
    {
        /// <summary>
        /// 媒体文件类型，分别有图片（image）、语音（voice）、视频（video）,普通文件(file)
        /// </summary>
       /// [JsonIgnore]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        [DataMember(Name = "type")]
        public MediaType Type { get; set; }
        /// <summary>
        /// 媒体文件上传后获取的唯一标识
        /// </summary>
         [DataMember(Name = "media_id")]
        public string MediaId { get; set; }
        /// <summary>
         /// 媒体文件上传时间戳
        /// </summary>
        [DataMember(Name = "created_at")]
         public long CreatedAt { get; set; }
    }
}

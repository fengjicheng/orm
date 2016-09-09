using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Qhyhgf.WeiXin.Qy.Api.Attribute;
using Qhyhgf.WeiXin.Qy.Api.Response;
using Qhyhgf.WeiXin.Qy.Api.Domain;
using System.Runtime.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.Request
{

    /// <summary>
    /// 上传多媒体
    /// </summary>
    [HttpMethod(Method = HttpVerb.File, Url = "https://qyapi.weixin.qq.com/cgi-bin/media/upload", Name = "上传媒体文件", IsToken = true, Serialize = SerializeVerb.Json)]
    public class MediaUploadRequest : IWeiXinRequest<MediaUploadResponse>
    {
        /// <summary>
        /// 媒体文件类型，分别有图片（image）、语音（voice）、视频（video），普通文件(file)
        /// </summary>
        [DataMember(Name = "type", IsRequired = true)]
        public MediaType Type { get; set; }
        /// <summary>
        /// 多媒体路径
        /// </summary>
        [DataMember(IsRequired = true, Name = "media")]
        public string Media { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Qhyhgf.WeiXin.Qy.Api.Attribute;
using Qhyhgf.WeiXin.Qy.Api.Response;
using System.Runtime.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.Request
{
    /// <summary>
    /// 获取媒体文件
    /// </summary>
    [HttpMethod(Method = HttpVerb.File, Url = "https://qyapi.weixin.qq.com/cgi-bin/media/get", Name = "获取媒体文件", IsToken = true, Serialize = SerializeVerb.Byte)]
    public class GetMediaRequest : IWeiXinRequest<GetMediaResponse>
    {
        /// <summary>
        /// 媒体文件id
        /// </summary>
        [DataMember(Name = "media_id", IsRequired = true)]
        public string MediaId { get; set; }
    }
}

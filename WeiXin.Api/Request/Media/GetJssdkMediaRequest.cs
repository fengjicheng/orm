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
    /// 获取高清语音素材
    /// 可以使用本接口获取从JSSDK的uploadVoice接口上传的临时语音素材，格式为speex，16K采样率。该音频比上文的临时素材获取接口（格式为amr，8K采样率）更加清晰，适合用作语音识别等对音质要求较高的业务。
    /// 仅企业微信2.4及以上版本支持。
    /// </summary>
    [HttpMethod(Method = HttpVerb.File, Url = "https://qyapi.weixin.qq.com/cgi-bin/media/get/jssdk", Name = "获取高清语音素材", IsToken = true, Serialize = SerializeVerb.Byte)]
    public class GetJssdkMediaRequest : IWeiXinRequest<GetJssdkMediaResponse>
    {
        /// <summary>
        /// 媒体文件id
        /// </summary>
        [DataMember(Name = "media_id", IsRequired = true)]
        public string MediaId { get; set; }
    }
}

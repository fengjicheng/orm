using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Domain;
using System.Text;
using System.Threading.Tasks;
using Qhyhgf.WeiXin.Qy.Api.Attribute;
using Qhyhgf.WeiXin.Qy.Api.Response;

namespace Qhyhgf.WeiXin.Qy.Api.Request
{
    /// <summary>
    /// 全量覆盖成员
    /// </summary>
    [Serializable]
    [DataContract]
    [HttpMethod(Method = HttpVerb.Post, Url = "https://qyapi.weixin.qq.com/cgi-bin/batch/replaceuser", Name = "全量覆盖成员", IsToken = true, Serialize = SerializeVerb.Json)]
    public class BatchReplaceuserRequest : IWeiXinRequest<BatchReplaceuserResponse>
    {
        /// <summary>
        /// 上传的csv文件的media_id
        /// </summary>
        [DataMember(Name = "media_id")]
        public string MediaId { get; set; }
        /// <summary>
        /// 回调信息。如填写该项则任务完成后，通过callback推送事件给企业。具体请参考应用回调模式中的相应选项
        /// </summary>
        [DataMember(Name = "callback")]
        public CallbackEntity Callback { get; set; }
    }
}

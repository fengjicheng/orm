using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Qhyhgf.WeiXin.Qy.Api.Attribute;
using Qhyhgf.WeiXin.Qy.Api.Response;

namespace Qhyhgf.WeiXin.Qy.Api.Request
{
    /// <summary>
    /// userid转换成openid接口
    /// 该接口使用场景为微信支付、微信红包和企业转账，企业号用户在使用微信支付的功能时，
    /// 需要自行将企业号的userid转成openid。在使用微信红包功能时，需要将应用id和userid转成appid和openid才能使用。
    /// </summary>
    [Serializable]
    [DataContract]
    [HttpMethod(Method = HttpVerb.Post, Url = "https://qyapi.weixin.qq.com/cgi-bin/user/convert_to_openid", Name = "userid转换成openid接口", IsToken = true, Serialize = SerializeVerb.Json)]
    public class ConvertToOpenidRequest: IWeiXinRequest<ConvertToOpenidResponse>
    {
        /// <summary>
        /// 企业号内的成员id
        /// </summary>
        [DataMember(Name = "userid", IsRequired = true)]
        public string UserId { get; set; }
        /// <summary>
        /// 标签ID
        /// </summary>
        [DataMember(Name = "agentid", IsRequired = true)]
        public string AgentId { get; set; }
    }
}

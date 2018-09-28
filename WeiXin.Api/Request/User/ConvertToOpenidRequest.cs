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
    /// 该接口使用场景为企业支付，在使用企业红包和向员工付款时，需要自行将企业微信的userid转成openid。
    /// 需要成员使用微信登录企业微信或者关注微工作台（原企业号）才能转成openid
    /// </summary>
    [Serializable]
    [DataContract]
    [HttpMethod(Method = HttpVerb.Post, Url = "https://qyapi.weixin.qq.com/cgi-bin/user/convert_to_openid", Name = "userid转换成openid接口", IsToken = true, Serialize = SerializeVerb.Json)]
    public class ConvertToOpenidRequest: IWeiXinRequest<ConvertToOpenidResponse>
    {
        /// <summary>
        /// 企业内的成员id
        /// </summary>
        [DataMember(Name = "userid", IsRequired = true)]
        public string UserId { get; set; }
    }
}

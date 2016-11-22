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
    /// openid转换成userid接口
    /// 该接口主要应用于使用微信支付、微信红包和企业转账之后的结果查询，
    /// 开发者需要知道某个结果事件的openid对应企业号内成员的信息时，可以通过调用该接口进行转换查询。
    /// </summary>
    [Serializable]
    [DataContract]
    [HttpMethod(Method = HttpVerb.Post, Url = "https://qyapi.weixin.qq.com/cgi-bin/user/convert_to_userid", Name = "openid转换成userid接口", IsToken = true, Serialize = SerializeVerb.Json)]

    public class ConvertToUseridRequest : IWeiXinRequest<ConvertToUseridResponse>
    {
        /// <summary>
        /// 企业号内的成员id
        /// </summary>
        [DataMember(Name = "openid", IsRequired = true)]
        public string OpenId { get; set; }
    }
}

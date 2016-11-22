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
    /// 根据code获取成员信息
    /// </summary>
    [HttpMethod(Method = HttpVerb.Get, Url = "https://qyapi.weixin.qq.com/cgi-bin/user/getuserinfo", Name = "根据code获取成员信息", IsToken = true, Serialize = SerializeVerb.Json)]
    public class GetUserInfoRequest : IWeiXinRequest<GetUserInfoResponse>
    {
        /// <summary>
        /// 通过成员授权获取到的code，每次成员授权带上的code将不一样，code只能使用一次，10分钟未被使用自动过期
        /// 可以使用 Qhyhgf.WeiXin.Qy.Api.Helpers.JumpAauthUrl构造跳转地址获得code
        /// </summary>
        [DataMember(Name = "code", IsRequired = true)]
        public string Code { get; set; }
    }
}

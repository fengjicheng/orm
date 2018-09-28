using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Qhyhgf.WeiXin.Qy.Api.Response;
using Qhyhgf.WeiXin.Qy.Api.Attribute;
using System.Runtime.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.Request
{
    /// <summary>
    /// 二次验证通过通知微信服务器
    /// </summary>
    [HttpMethod(Method = HttpVerb.Get, Url = "https://qyapi.weixin.qq.com/cgi-bin/user/authsucc", Name = "二次验证通过通知微信服务器", IsToken = true, Serialize = SerializeVerb.Json)]
    public class AuthsuccUserRequest : IWeiXinRequest <AuthsuccUserResponse>
    {
        /// <summary>
        ///成员UserID。对应管理端的帐号
        /// </summary>
        [DataMember(Name = "userid", IsRequired = true)]
        public string UserId { get; set; }
    }
}

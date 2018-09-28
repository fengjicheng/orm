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
    /// 删除成员
    /// </summary>
    [HttpMethod(Method = HttpVerb.Get, Url = "https://qyapi.weixin.qq.com/cgi-bin/user/delete", Name = "删除成员", IsToken = true, Serialize = SerializeVerb.Json)]
    public class DeleteUserRequest : IWeiXinRequest<DeleteUserResponse>
    {
        /// <summary>
        /// 员工UserID。对应管理端的帐号
        /// </summary>
        [DataMember(Name = "userid", IsRequired = true)]
        public string UserId { get; set; }
    }
}

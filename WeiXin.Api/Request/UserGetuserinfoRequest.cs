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
    /// 根据code获取成员信息
    /// </summary>
    [HttpMethod(Method = HttpVerb.Get, Url = "https://qyapi.weixin.qq.com/cgi-bin/media/get", Name = "根据code获取成员信息", IsToken = true, Serialize = SerializeVerb.Json)]
    public class UserGetuserinfoRequest : IWeiXinRequest<UserGetuserinfoResponse>
    {
        /// <summary>
        /// 通过员工授权获取到的code，每次员工授权带上的code将不一样，code只能使用一次，5分钟未被使用自动过期
        /// </summary>
        [DataMember(Name = "code", IsRequired = true)]
        public string Code { get; set; }
        /// <summary>
        /// 跳转链接时所在的企业应用ID
        /// </summary>
        [DataMember(Name = "agentid",IsRequired=true)]
        public string AgentId { get; set; }
    }
}

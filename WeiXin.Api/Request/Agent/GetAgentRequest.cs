using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Attribute;
using Qhyhgf.WeiXin.Qy.Api.Response;

namespace Qhyhgf.WeiXin.Qy.Api.Request
{
    /// <summary>
    /// 获取企业号应用
    /// </summary>
    [Serializable]
    [DataContract]
    [HttpMethod(Method = HttpVerb.Get, Url = "https://qyapi.weixin.qq.com/cgi-bin/agent/get", Name = "获取企业号应用", IsToken = true, Serialize = SerializeVerb.Json)]
    public class GetAgentRequest : IWeiXinRequest<GetAgentResponse>
    {
        /// <summary>
        /// 授权方应用id
        /// </summary>
        [DataMember(Name = "agentid", IsRequired = true)]
        public int Agentid { get; set; }
    }
}

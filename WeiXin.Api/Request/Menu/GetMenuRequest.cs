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
    /// 获取菜单列表
    /// </summary>
    [HttpMethod(Method = HttpVerb.Get, Url = "https://qyapi.weixin.qq.com/cgi-bin/menu/get", Name = "获取菜单列表", IsToken = true, Serialize = SerializeVerb.None)]
    public class GetMenuRequest : IWeiXinRequest<GetMenuResponse>
    {
        /// <summary>
        /// 企业应用的id，整型。可在应用的设置页面查看
        /// </summary>
        [DataMember(Name = "agentid", IsRequired = true)]
        public string AgentId { get; set; }
    }
}

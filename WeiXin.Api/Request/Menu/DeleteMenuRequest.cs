using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Qhyhgf.WeiXin.Qy.Api.Response;
using System.Runtime.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Attribute;

namespace Qhyhgf.WeiXin.Qy.Api.Request
{
    /// <summary>
    /// 删除菜单
    /// </summary>
    [Serializable]
    [DataContract]
    [HttpMethod(Method = HttpVerb.Get, Url = "https://qyapi.weixin.qq.com/cgi-bin/menu/delete", Name = "删除菜单", IsToken = true, Serialize = SerializeVerb.None)]
    public class DeleteMenuRequest : IWeiXinRequest<DeleteMenuResponse>
    {
        /// <summary>
        /// 标签ID
        /// </summary>
        [DataMember(Name = "agentid", IsRequired = true)]
        public string AgentId { get; set; }
    }
}

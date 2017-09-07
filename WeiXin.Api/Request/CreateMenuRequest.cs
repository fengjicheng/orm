using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Response;
using Qhyhgf.WeiXin.Qy.Api.Attribute;
using Qhyhgf.WeiXin.Qy.Api.Domain;
using Newtonsoft.Json;
using Qhyhgf.WeiXin.Qy.Api.Domain.Menu;

namespace Qhyhgf.WeiXin.Qy.Api.Request
{
    /// <summary>
    /// 创建菜单
    /// </summary>
    [Serializable]
    [DataContract]
    [HttpMethod(Method = HttpVerb.Post, Url = "https://qyapi.weixin.qq.com/cgi-bin/menu/create", Name = "创建菜单", IsToken = true, Serialize = SerializeVerb.Json)]
    public class CreateMenuRequest : IWeiXinRequest<CreateMenuResponse>
    {
        public CreateMenuRequest()
        {
            Buttons = new List<MenuEventBase>();
        }
        /// <summary>
        /// 企业应用的id，整型。可在应用的设置页面查看
        /// </summary>
        [GetParameter(Name = "agentid",IsRequired=true)]
        public string AgentId { get; set; }
        [DataMember(Name = "button")]
        public IList<MenuEventBase> Buttons { get; set; }
    }
}

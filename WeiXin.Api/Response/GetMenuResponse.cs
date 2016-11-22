using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Domain;
using Qhyhgf.WeiXin.Qy.Api.Domain.Menu;

namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    public class GetMenuResponse:WeiXinResponse
    {
        /// <summary>
        /// 按钮组
        /// </summary>
        [DataMember(Name = "menu")]
        public MenuEntity Menu { get; set; }
    }
}

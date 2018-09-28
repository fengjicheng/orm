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
        public GetMenuResponse()
        {
            Buttons = new List<MenuButtonBase>();
        }
        [DataMember(Name = "button")]
        public IList<MenuButtonBase> Buttons { get; set; }
    }
}

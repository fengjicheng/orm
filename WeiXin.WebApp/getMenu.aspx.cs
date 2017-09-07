using Qhyhgf.WeiXin.Qy.Api.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WeiXin.WebUi
{
    public partial class getMenu : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Qhyhgf.WeiXin.Qy.Api.Token.TokenEntity Entity = new Qhyhgf.WeiXin.Qy.Api.Token.ConfingToken().Handle("43");
            client.Token = Entity;
            Qhyhgf.WeiXin.Qy.Api.Request.GetMenuRequest getMenuRequest = new Qhyhgf.WeiXin.Qy.Api.Request.GetMenuRequest();
            getMenuRequest.AgentId = "43";
            Qhyhgf.WeiXin.Qy.Api.Response.GetMenuResponse getMenuResponse = client.Execute<Qhyhgf.WeiXin.Qy.Api.Response.GetMenuResponse>(getMenuRequest);
            Response.Write(getMenuResponse.objToJson());
        }
    }
}
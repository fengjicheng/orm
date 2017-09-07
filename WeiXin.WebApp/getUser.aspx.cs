using Qhyhgf.WeiXin.Qy.Api;
using Qhyhgf.WeiXin.Qy.Api.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Qhyhgf.WeiXin.Qy.Api.Helpers;

namespace WeiXin.WebUi
{
    public partial class getUser : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Qhyhgf.WeiXin.Qy.Api.Request.GetUserRequest getUser = new Qhyhgf.WeiXin.Qy.Api.Request.GetUserRequest();
            getUser.UserId = "16338";
            Qhyhgf.WeiXin.Qy.Api.Response.GetUserResponse getUserData = client.Execute<Qhyhgf.WeiXin.Qy.Api.Response.GetUserResponse>(getUser);
            Response.Write(getUserData.objToJson());
        }
    }
}
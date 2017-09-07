using Qhyhgf.WeiXin.Qy.Api.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WeiXin.WebUi
{
    public partial class updateUser : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Qhyhgf.WeiXin.Qy.Api.Request.UpdateUserRequest updateUser = new Qhyhgf.WeiXin.Qy.Api.Request.UpdateUserRequest();
            updateUser.UserId = "16338";
            updateUser.Email = "caoxiancc@live.cn";
            updateUser.Enable = 1;
            Qhyhgf.WeiXin.Qy.Api.Response.UpdateUserResponse results = client.Execute<Qhyhgf.WeiXin.Qy.Api.Response.UpdateUserResponse>(updateUser);
            Response.Write(results.objToJson());


        }
    }
}
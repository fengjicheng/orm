using Qhyhgf.WeiXin.Qy.Api.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WeiXin.WebUi
{
    public partial class ListAgent :PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Qhyhgf.WeiXin.Qy.Api.Request.ListAgentRequest listAgentRequest = new Qhyhgf.WeiXin.Qy.Api.Request.ListAgentRequest();
            Qhyhgf.WeiXin.Qy.Api.Response.ListAgentResponse listAgentResponse = client.Execute<Qhyhgf.WeiXin.Qy.Api.Response.ListAgentResponse>(listAgentRequest);
            Response.Write(listAgentResponse.objToJson());
        }
    }
}
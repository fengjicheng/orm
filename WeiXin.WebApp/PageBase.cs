using Qhyhgf.WeiXin.Qy.Api.Config;
using Qhyhgf.WeiXin.Qy.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeiXin.WebUi
{
    public class PageBase: System.Web.UI.Page
    {
        WeiXinSection section = WeiXinSection.GetInstance();

        public IWeiXinClient client = new DefaultWeiXinClient();


        protected override void OnInit(EventArgs e)
        {
            Qhyhgf.WeiXin.Qy.Api.Token.TokenEntity Entity = new Qhyhgf.WeiXin.Qy.Api.Token.ConfingToken().Handle("2000002");
            client.Token = Entity;
            base.OnInit(e);
        }
    }
}
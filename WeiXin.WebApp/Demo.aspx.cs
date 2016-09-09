using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Qhyhgf.WeiXin.Qy.Api;

namespace WeiXin.WebUi
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IWeiXinClient client = new DefaultWeiXinClient();
            Qhyhgf.WeiXin.Qy.Api.TokenFachory.TokenEntity Entity = new Qhyhgf.WeiXin.Qy.Api.TokenFachory.TokenEntity();
            Entity  = Qhyhgf.WeiXin.Qy.Api.TokenFachory.TokenManager.CreakDefault();
            client.Token = Entity;
            Qhyhgf.WeiXin.Qy.Api.Request.MediaUploadRequest mediaUploadRequest = new Qhyhgf.WeiXin.Qy.Api.Request.MediaUploadRequest();
            mediaUploadRequest.Media = @"D:\WeiXin\trunk\WeiXin.WebApp\1.jpg";
            mediaUploadRequest.Type = Qhyhgf.WeiXin.Qy.Api.Domain.MediaType.Image;
            Qhyhgf.WeiXin.Qy.Api.Response.MediaUploadResponse MediaUploadResponse
                = client.Execute<Qhyhgf.WeiXin.Qy.Api.Response.MediaUploadResponse>(mediaUploadRequest);
        }
    }
}
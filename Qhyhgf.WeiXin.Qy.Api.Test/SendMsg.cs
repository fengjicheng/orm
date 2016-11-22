using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Qhyhgf.WeiXin.Qy.Api.Token;
using Qhyhgf.WeiXin.Qy.Api.Request;
using Qhyhgf.WeiXin.Qy.Api.Response;
using Qhyhgf.WeiXin.Qy.SeedMessage;

namespace Qhyhgf.WeiXin.Qy.Api.Test
{
    [TestClass]
    public class SendMsg
    {
        [TestMethod]
        public void MediaUpload()
        {
            TokenManager manger = new TokenManager();
            TokenEntity entiy = manger.GetToken("0");
            IWeiXinClient client = new DefaultWeiXinClient();
            client.Token = entiy;
            MediaUploadRequest mediaUploadRequest =new MediaUploadRequest();
            mediaUploadRequest.Media = @"D:\证件照片\DSCF8856.JPG";
            mediaUploadRequest.Type = Domain.MediaType.Image;
            MediaUploadResponse MediaUploadResponse = client.Execute<MediaUploadResponse>(mediaUploadRequest);
            Assert.IsNotNull(MediaUploadResponse.MediaId);
        }
        [TestMethod]
        public void AgentList()
        {
            TokenManager manger = new TokenManager();
            TokenEntity entiy = manger.GetToken("0");
            IWeiXinClient client = new DefaultWeiXinClient();
            client.Token = entiy;
            AgentListRequest AgentListRequest = new AgentListRequest();
            AgentListResponse MediaUploadResponse = client.Execute<AgentListResponse>(AgentListRequest);
            Assert.AreEqual(MediaUploadResponse.ErrCode,0);
        }
    }
}

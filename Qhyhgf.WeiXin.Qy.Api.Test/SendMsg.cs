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
using System.Drawing;
using Qhyhgf.WeiXin.Qy.Api.Helpers;
using System.IO;

namespace Qhyhgf.WeiXin.Qy.Api.Test
{
    [TestClass]
    public class SendMsg
    {
        [TestMethod]
        public void MediaUpload()
        {
            //Image img = Image.FromFile(@"D:\1.tga");
            //byte[] imgb;
            //using (MemoryStream mostream = new MemoryStream())
            //{
            //    Bitmap bmp = new Bitmap(img);
            //
            //    bmp.Save(mostream, System.Drawing.Imaging.ImageFormat.Jpeg);//将图像以指定的格式存入缓存内存流
            //
            //    imgb = new byte[mostream.Length];
            //
            //    mostream.Position = 0;//设置留的初始位置
            //
            //    mostream.Read(imgb, 0, Convert.ToInt32(imgb.Length));
            //
            //}
           /// byte[] imgb;
           // using (FileStream fs = new FileStream(@"D:\favicon.ico", FileMode.Open))
           // {
           //     imgb = new byte[fs.Length];
           //     fs.Read(imgb, 0, (int)fs.Length);
           // }
           // string imgtype = imgb.GetImageType();
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

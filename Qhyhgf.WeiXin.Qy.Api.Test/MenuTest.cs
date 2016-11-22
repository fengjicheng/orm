using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Qhyhgf.WeiXin.Qy.Api.Domain.Menu;
using Qhyhgf.WeiXin.Qy.Api.Token;
using Qhyhgf.WeiXin.Qy.Api.Helpers;
using Qhyhgf.WeiXin.Qy.Api.Request;
using Qhyhgf.WeiXin.Qy.Api.Response;

namespace Qhyhgf.WeiXin.Qy.Api.Test
{

    [TestClass]
    public class MenuTest
    {
        [TestMethod]
        public void MenuJson()
        {
            MenuEntity entity = new MenuEntity();
            entity.Buttons.Add(new ClickEvent { Name ="测试", Key ="KEY1" });
            entity.Buttons.Add(new MenuEventBase {
                   Name ="主页",
                   SubButton =new List<MenuEventBase> {
                       new ClickEvent { Name ="测试2", Key ="KEY2" },
                       new ClickEvent { Name ="测试3", Key ="KEY3" }
                   }
            });
            string json = entity.objToJson();
            Assert.IsNotNull(json);
            ///反序列化
            MenuEntity menu = json.jsonToObj<MenuEntity>();
            Assert.IsNotNull(menu);
        }
        [TestMethod]
        public void CreatMenuTest() {
            TokenManager manger = new TokenManager();
            TokenEntity entiy = manger.GetToken("0");
            IWeiXinClient client = new DefaultWeiXinClient();
            client.Token = entiy;
            CreateMenuRequest request = new CreateMenuRequest();
            MenuEntity entity = new MenuEntity();
            entity.Buttons.Add(new ClickEvent { Name = "测试", Key = "KEY1" });
            entity.Buttons.Add(new MenuEventBase
            {
                Name = "主页",
                SubButton = new List<MenuEventBase> {
                       new LocationSelectEvent { Name ="上传坐标", Key ="KEY2" },
                       new PicSysphotoEvent { Name ="拍照发图", Key ="KEY3" }
                   }
            });
            request.Menu = entity;
            request.AgentId = entiy.AgentID;
            CreateMenuResponse response = client.Execute<CreateMenuResponse>(request);
            Assert.AreEqual(0, response.ErrCode);
        }
        [TestMethod]
        public void GetMenuTest()
        {
            TokenManager manger = new TokenManager();
            TokenEntity entiy = manger.GetToken("0");
            IWeiXinClient client = new DefaultWeiXinClient();
            client.Token = entiy;
            GetMenuRequest request = new GetMenuRequest();
            request.AgentId = entiy.AgentID;
            GetMenuResponse response = client.Execute<GetMenuResponse>(request);
            Assert.AreEqual(0, response.ErrCode);
        }
    }
}

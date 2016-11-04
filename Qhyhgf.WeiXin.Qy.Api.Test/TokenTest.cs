using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Qhyhgf.WeiXin.Qy.Api.Token;

namespace Qhyhgf.WeiXin.Qy.Api.Test
{

    [TestClass]
    public class TokenTest
    {
        [TestMethod]
        public void TokenManagerCreakToken()
        {
            TokenManager manger = new TokenManager();
            TokenEntity entiy = manger.GetToken("0");
            Assert.IsNotNull(entiy.AccessToken);
        }
    }
}

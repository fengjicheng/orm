using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Qhyhgf.WeiXin.Qy.Api.TokenFachory;

namespace Qhyhgf.WeiXin.Qy.Api.Test
{

    [TestClass]
    public class Token
    {
        [TestMethod]
        public void TokenManagerCreakToken()
        {
            TokenEntity entity = TokenManager.CreakDefault();
            entity.GetAccessToken();

            Assert.IsNull(entity);
        }
    }
}

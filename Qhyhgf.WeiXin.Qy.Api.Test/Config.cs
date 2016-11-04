using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Qhyhgf.WeiXin.Qy.Api.Config;

namespace Qhyhgf.WeiXin.Qy.Api.Test
{
    [TestClass]
    public class Config
    {
        WeiXinSection section = WeiXinSection.GetInstance();
        [TestMethod]
        public void TestConfigWeiXinSectionCorpID()
        {
            //验证 corpid
            Assert.AreEqual(section.CorpID, "wx372c5bf3a85c603b");   
        }
        [TestMethod]
        public void TestConfigKeyValuesCount()
        {
            //section节点数量
            Assert.AreEqual(section.KeyValues.Count, 3);
        }
        [TestMethod]
        public void TestConfigWeiXinKeyValueSetting()
        {
            WeiXinKeyValueSetting keyValueItem = section.KeyValues["0"];
            //section节点数量
            Assert.AreEqual(keyValueItem.AgentID, "0");
            Assert.AreEqual(keyValueItem.Token, "gqOBM0Bcu22U1cp");
            Assert.AreEqual(keyValueItem.EncodingAESKey, "5MOjHcvfSOLxqcmHP0O546w9Hlxtd7Y1rgIKFNP5G2d");
            Assert.AreEqual(keyValueItem.Secret, "Dc-qL-quALvm9M6UT9V1VxFrTHRE8b114Yvde33C3tv15pxdk_pH33pms8MjNepj");
            Assert.AreEqual(keyValueItem.Name, "OA助手");
        }


    }
}

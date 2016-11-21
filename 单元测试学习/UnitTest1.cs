using System;
using System.Diagnostics;
using NUnit.Framework;

namespace 单元测试学习
{
    [TestFixture(Description = "测试示例")]
    public class UnitTest1
    {
        [OneTimeSetUp]
        public void Initialize()
        {
            Console.WriteLine("本测试类初始化信息");
        }
        [OneTimeTearDown]
        public void Dispose()
        {
            Console.WriteLine("释放资源");
        }
        public string test;
        [SetUp]
        public void SetUpForTest (){
            test = "测试之前运行";
        }
        [Test(Description = "加法")]
        [Category("优先级 1")]
        [TestCase(1)]
        public void TestMethod1(string arg)
        {
            if (test== "测试之前运行")
            {
                //测试通过
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
        [TearDown]
        public void TearDownTest() {
            test = "测试之后清理工作";
        }

    }
}

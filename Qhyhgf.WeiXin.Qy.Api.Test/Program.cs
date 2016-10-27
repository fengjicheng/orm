using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Qhyhgf.WeiXin.Qy;
using Qhyhgf.WeiXin.Qy.Api.Config;

namespace Qhyhgf.WeiXin.Qy.Api.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            #region web.config配置信息
            WeiXinSection section = WeiXinSection.GetInstance();

            #endregion
            //DemoColumnsAndValues();
            //DemoValues();
            //DemoSqlExpr();
            //DemoWhere();
            //DemoSet();
            //DemoOrderBy();
            //DemoColumns();
        }
    }
}

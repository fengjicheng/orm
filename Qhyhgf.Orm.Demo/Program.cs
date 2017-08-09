using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Qhyhgf.Orm.Demo
{
    class Program
    {
        public static string ConnectionString { get; set; }
        static void Main(string[] args)
        {
            ConnectionStringSettings setting = ConfigurationManager.ConnectionStrings["HrMSSQL"];
            ConnectionString = setting.ConnectionString;
        }
    }
}

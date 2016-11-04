using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 状态模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            context.setState(new ConcreteStateA());
            context.request("你好");
        }
    }
}

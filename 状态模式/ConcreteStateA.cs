using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 状态模式
{
    public class ConcreteStateA : State
    {
        public void handle(string sampleParameter)
        {
            Console.WriteLine("ConcreteStateA handle ：" + sampleParameter);
        }
    }
}

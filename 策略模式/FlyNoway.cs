using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    public class FlyNoway : IFlyBehavior
    {
        public void fly()
        {
            Console.Write("I can't fly");
        }
    }
}

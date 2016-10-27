using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    public class RubberDuck : Duck
    {
        public RubberDuck() {
            flyBehavior = new FlyNoway();
            quackBehavior = new MuteQuack();

        }
        public override void display()
        {
            Console.Write(" I'm 橡皮鸭子");
        }
    }
}

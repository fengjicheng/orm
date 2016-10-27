using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new RubberDuck();
            //说出名字
            duck.display();
            //飞行
            duck.performFly();
            //叫
            duck.performQuack();
            //动态改变行为
            duck.setFlyBehavior(new FlyWithWings());
            //说出名字
            duck.display();
            //飞行
            duck.performFly();
            //叫
            duck.performQuack();
            //动态改变行为

        }
    }
}

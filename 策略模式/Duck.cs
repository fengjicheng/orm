using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;
        public abstract void display();
        public void performFly() {
            flyBehavior.fly();
        }
        public void performQuack() {
            quackBehavior.quack();
        }
        public void setFlyBehavior(IFlyBehavior ifb)
        {
            flyBehavior = ifb;
        }
        public void setQuackBehavior(IQuackBehavior iqb)
        {
            quackBehavior = iqb;
        }
    }
}

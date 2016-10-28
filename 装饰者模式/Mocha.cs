using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰者模式
{
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;
        public Mocha(Beverage bever)
        {
            beverage = bever;
        }
        public override double cost()
        {
            return this.beverage.cost() +0.2;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + " , Mocha";
        }
    }
}

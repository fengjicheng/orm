using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            //不要调料
            Console.WriteLine(beverage.getDescription()+" $ "+beverage.cost());
            //
            Beverage beverage2 = new Espresso();
            beverage2 = new Mocha(beverage2);
            Console.WriteLine(beverage2.getDescription() + " $ " + beverage2.cost());

        }
    }
}

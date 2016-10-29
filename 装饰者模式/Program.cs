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
            #region demo 1
            Beverage beverage = new Espresso();
            //不要调料
            Console.WriteLine(beverage.getDescription()+" $ "+beverage.cost());
            //
            Beverage beverage2 = new Espresso();
            beverage2 = new Mocha(beverage2);
            Console.WriteLine(beverage2.getDescription() + " $ " + beverage2.cost());

            #endregion;

            // 我买了个苹果手机
            Phone phone = new ApplePhone();

            // 现在想贴膜了
            Decorator applePhoneWithSticker = new Sticker(phone);
            // 扩展贴膜行为
            applePhoneWithSticker.Print();
            Console.WriteLine("----------------------\n");

            // 现在我想有挂件了
            Decorator applePhoneWithAccessories = new Accessories(phone);
            // 扩展手机挂件行为
            applePhoneWithAccessories.Print();
            Console.WriteLine("----------------------\n");

            // 现在我同时有贴膜和手机挂件了
            Sticker sticker = new Sticker(phone);
            Accessories applePhoneWithAccessoriesAndSticker = new Accessories(sticker);
            applePhoneWithAccessoriesAndSticker.Print();
            Console.ReadLine();
        }
    }
}

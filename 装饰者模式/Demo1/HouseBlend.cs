using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰者模式
{
    public class HouseBlend : Beverage
    {
        public HouseBlend() {
            description = "Hose Blend Coffee";
        }
        public override double cost()
        {
            return .89;
        }
    }
}

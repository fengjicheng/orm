using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰者模式
{
    public abstract class Beverage
    {
        protected string description = "Unknown Beverage";
        public string getDescription() {
            return description;
        }
        public abstract double cost();

    }
}

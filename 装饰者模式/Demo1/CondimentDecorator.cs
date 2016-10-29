using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰者模式
{
    /// <summary>
    /// 调料 抽象类，装饰者类
    /// </summary>
    public abstract class CondimentDecorator:Beverage
    {
        public new abstract string getDescription();
    }
}

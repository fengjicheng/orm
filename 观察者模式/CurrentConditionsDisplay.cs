using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private string msg;
        private ISubject weatherData;
        public CurrentConditionsDisplay(ISubject weather)
        {
            weatherData = weather;
            weatherData.registerObserver(this);
        }
        public void display()
        {
            Console.WriteLine("CurrentConditionsDisplay有更新" + this.msg);
        }

        public void update(string _msg)
        {
            this.msg = _msg;
            display();
        }
    }
}

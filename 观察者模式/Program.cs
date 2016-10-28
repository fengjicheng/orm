using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weather = new WeatherData();
            CurrentConditionsDisplay current = new CurrentConditionsDisplay(weather);
         
            weather.setMsg("你好");
        }
    }
}

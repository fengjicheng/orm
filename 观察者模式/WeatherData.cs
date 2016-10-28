using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    public class WeatherData : ISubject
    {
        private IDictionary<string,IObserver> observers;
        private string msg;
        public WeatherData() {
            observers = new Dictionary<string, IObserver>();

        }
        public void notifyObservers()
        {
            foreach (var item in observers)
            {
                item.Value.update(msg);
            }
        }

        public void registerObserver(IObserver ob)
        {
            observers.Add(ob.GetHashCode().ToString(), ob);
        }

        public void removeObserver(IObserver ob)
        {
            observers.Remove(ob.GetHashCode().ToString());
        }
        public void setMsg(string m)
        {
            msg = m;
            ///有数据改变则进行通知
            notifyObservers();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    public interface ISubject
    {
        void registerObserver(IObserver ob);
        void removeObserver(IObserver ob);
        /// <summary>
        /// 当前状态改变时发生
        /// </summary>
        void notifyObservers();
    }
}

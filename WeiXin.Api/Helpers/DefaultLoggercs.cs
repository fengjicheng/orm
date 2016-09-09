using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace Qhyhgf.WeiXin.Qy.Api.Helpers
{
    /// <summary>
    /// 日志功能
    /// </summary>
    public class DefaultLoggercs:Iloger
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(DefaultLoggercs));
        void Iloger.Error(string message)
        {
            log.Error(message);
            Console.WriteLine(message);
        }

        void Iloger.Warn(string message)
        {
            log.Warn(message);
            Console.WriteLine(message);
        }

        void Iloger.Info(string message)
        {
            log.Info(message);
            Console.WriteLine(message);
        }

        void IDisposable.Dispose()
        {

        }
    }
}

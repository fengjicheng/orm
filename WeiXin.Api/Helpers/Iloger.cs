using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qhyhgf.WeiXin.Qy.Api.Helpers
{
    /// <summary>
    /// 日志接口
    /// </summary>
    public interface Iloger:IDisposable
    {
        void Error(string message);
        void Warn(string message);
        void Info(string message);
    }
}

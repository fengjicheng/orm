using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qhyhgf.Orm
{
    /// <summary>
    /// Orm异常类
    /// </summary>
    public class OrmException:System.Exception
    {
        public OrmException(string msg):base(msg)
        {
        }
    }
}

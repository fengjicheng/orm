using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 状态模式
{
    public interface State
    {
       
       // 状态对应的处理
        void handle(String sampleParameter);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 状态模式
{
    public class Context
    {
        //持有一个State类型的对象实例
        private State state;
        public void setState(State state)
        {
            this.state = state;
        }
        /// <summary>
        /// 用户感兴趣的接口方法
        /// </summary>
        /// <param name="sampleParameter"></param>
        public void request(String sampleParameter)
        {
            //转调state来处理
            state.handle(sampleParameter);
        }
    }
}

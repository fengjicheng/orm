using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qhyhgf.WeiXin.Qy.Api.Token
{

    public interface ITokenState
    {
        /// <summary>
        /// 传递企业应用的id
        /// </summary>
        /// <param name="AgentID"></param>
        /// <returns></returns>
        TokenEntity Handle(string AgentID);
    }
}

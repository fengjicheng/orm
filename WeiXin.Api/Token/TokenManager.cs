using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Qhyhgf.WeiXin.Qy.Api.Config;

namespace Qhyhgf.WeiXin.Qy.Api.Token
{
    public class TokenManager
    {
        ITokenState state;
        private static Dictionary<string, TokenEntity> dic = new Dictionary<string, TokenEntity>();
        public TokenManager(ITokenState its)
        {
            state = its;
        }
        public TokenManager() {
            state = new ConfingToken();
        }
        public TokenEntity GetToken(string AgentID)
        {
            TokenEntity entity = new TokenEntity();
            if (dic.ContainsKey(AgentID))
            {
                entity = dic[AgentID];
            }
            else
            {
                entity = state.Handle(AgentID);
                dic.Add(AgentID, entity);
            }
            return entity;
        }
    }
}

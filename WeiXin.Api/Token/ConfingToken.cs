using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qhyhgf.WeiXin.Qy.Api.Config;

namespace Qhyhgf.WeiXin.Qy.Api.Token
{

    public class ConfingToken : ITokenState
    {
        public TokenEntity Handle(string AgentID)
        {
            TokenEntity entity = new TokenEntity();
            WeiXinSection section = WeiXinSection.GetInstance();
            entity.CorpID = section.CorpID;
            WeiXinCollection keyValues = section.KeyValues;
            WeiXinKeyValueSetting keyItem = keyValues[AgentID];
            entity.AgentID = AgentID;
            entity.Token = keyItem.Token;
            entity.EncodingAESKey = keyItem.EncodingAESKey;
            entity.Secret = keyItem.Secret;
            entity.Name = keyItem.Name;
            return entity;
        }
    }
}

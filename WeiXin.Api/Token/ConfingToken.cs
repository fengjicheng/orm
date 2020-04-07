using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qhyhgf.WeiXin.Qy.Api.Config;
/*
                           _ooOoo_
                          o8888888o
                          88" . "88
                          (| -_- |)
                          O\  =  /O
                       ____/`---'\____
                     .'  \\|     |//  `.
                    /  \\|||  :  |||//  \
                   /  _||||| -:- |||||-  \
                   |   | \\\  -  /// |   |
                   | \_|  ''\---/''  |   |
                   \  .-\__  `-`  ___/-. /
                 ___`. .'  /--.--\  `. . __
              ."" '<  `.___\_<|>_/___.'  >'"".
             | | :  `- \`.;`\ _ /`;.`/ - ` : | |
             \  \ `-.   \_ __\ /__ _/   .-` /  /
        ======`-.____`-.___\_____/___.-`____.-'======
                           `=---='
        ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
                 佛祖保佑       永无BUG
        *********************************************
        * 作者：冯际成
        * 单位：青海盐湖工业股份有限公司信息中心
        * 电话：15209793953
 */
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

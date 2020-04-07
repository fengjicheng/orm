using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

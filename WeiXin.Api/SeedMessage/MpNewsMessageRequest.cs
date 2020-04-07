using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Request;
using Qhyhgf.WeiXin.Qy.Api.Attribute;
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
namespace Qhyhgf.WeiXin.Qy.Api.SeedMessage
{
    /// <summary>
    /// mpnews消息
    /// mpnews消息与news消息类似，不同的是图文消息内容存储在微信后台，并且支持保密选项。
    /// </summary>
    [HttpMethod(Method = HttpVerb.Post, Url = "https://qyapi.weixin.qq.com/cgi-bin/message/send", Name = "主动发送消息", IsToken = true, Serialize = SerializeVerb.Json)]
    public class MpNewsMessageRequest : SendMessageRequest
    {
        public MpNewsMessageRequest()
        {
            MsgType = Domain.MessageType.MpNews;
            MpNews = new MpNewsList();
            Safe = "0";
        }
        /// <summary>
        /// 图片内容
        /// </summary>
        [DataMember(Name = "mpnews")]
        public MpNewsList MpNews { get; set; }
        /// <summary>
        /// 表示是否是保密消息，0表示否，1表示是，默认0
        /// </summary>
        [DataMember(Name = "safe")]
        public string Safe { get; set; }
    }
}

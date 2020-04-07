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
    /// 文件消息
    /// </summary>
    [HttpMethod(Method = HttpVerb.Post, Url = "https://qyapi.weixin.qq.com/cgi-bin/message/send", Name = "主动发送消息", IsToken = true, Serialize = SerializeVerb.Json)]
    public class FileMessageRequest : SendMessageRequest
    {
        public FileMessageRequest()
        {
            MsgType = Domain.MessageType.File;
            Safe = "0";
            File = new FileEntity();
        }
        /// <summary>
        /// 文件内容
        /// </summary>
        [DataMember(Name = "file")]
        public FileEntity File { get; set; }
        /// <summary>
        /// 表示是否是保密消息，0表示否，1表示是，默认0
        /// </summary>
        [DataMember(Name = "safe")]
        public string Safe { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Attribute;
using Qhyhgf.WeiXin.Qy.Api.Response;
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
namespace Qhyhgf.WeiXin.Qy.Api.Request
{
    /// <summary>
    /// 邀请成员关注
    /// </summary>
    [Serializable]
    [DataContract]
    [HttpMethod(Method = HttpVerb.Post, Url = "https://qyapi.weixin.qq.com/cgi-bin/invite/send", Name = "邀请成员关注", IsToken = true, Serialize = SerializeVerb.Json)]
    public class SendInviteRequest : IWeiXinRequest<SendInviteResponse>
    {
        /// <summary>
        /// 用户的userid
        /// </summary>
        [DataMember(Name = "userid", IsRequired = true)]
        public string UserId { get; set; }
        /// <summary>
        /// 推送到微信上的提示语（只有认证号可以使用）。当使用微信推送时，该字段默认为“请关注XXX企业号”，邮件邀请时，该字段无效。
        /// </summary>
        [DataMember(Name = "invite_tips", IsRequired = false)]
        public string InviteTips { get; set; }
    }
}

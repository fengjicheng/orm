using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Domain;
using System.Text;
using System.Threading.Tasks;
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
    /// 批量增量更新成员
    ///1.模板中的部门需填写部门ID，多个部门用分号分隔，部门ID必须为数字，跟部门的部门id默认为1
    ///2.文件中存在、通讯录中也存在的成员，更新成员在文件中指定的字段值
    ///3.文件中存在、通讯录中不存在的成员，执行添加操作
    ///4.通讯录中存在、文件中不存在的成员，保持不变
    //5.成员字段更新规则：可自行添加扩展字段。文件中有指定的字段，以指定的字段值为准；文件中没指定的字段，不更新
    /// </summary>
    [Serializable]
    [DataContract]
    [HttpMethod(Method = HttpVerb.Post, Url = "https://qyapi.weixin.qq.com/cgi-bin/batch/syncuser", Name = "批量增量更新成员", IsToken = true, Serialize = SerializeVerb.Json)]
    public class BatchSyncUserRequest : IWeiXinRequest<BatchSyncUserResponse>
    {
        /// <summary>
        /// 上传的csv文件的media_id
        /// </summary>
        [DataMember(Name = "media_id")]
        public string MediaId { get; set; }
        /// <summary>
        /// 是否邀请新建的成员使用企业微信（将通过微信服务通知或短信或邮件下发邀请，每天自动下发一次，最多持续3个工作日），默认值为true。
        /// </summary>
        [DataMember(Name = "to_invite")]
        public string ToInvite { get; set; }
        /// <summary>
        /// 回调信息。如填写该项则任务完成后，通过callback推送事件给企业。具体请参考应用回调模式中的相应选项
        /// </summary>
        [DataMember(Name = "callback")]
        public CallbackEntity Callback { get; set; }
    }
}

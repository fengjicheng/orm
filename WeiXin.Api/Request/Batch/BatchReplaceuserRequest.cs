using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Domain;
using System.Text;
using System.Threading.Tasks;
using Qhyhgf.WeiXin.Qy.Api.Attribute;
using Qhyhgf.WeiXin.Qy.Api.Response;

namespace Qhyhgf.WeiXin.Qy.Api.Request
{
    /// <summary>
    /// 全量覆盖成员
    ///1.模板中的部门需填写部门ID，多个部门用分号分隔，部门ID必须为数字，跟部门的部门id默认为1
    //2.文件中存在、通讯录中也存在的成员，完全以文件为准
    //3.文件中存在、通讯录中不存在的成员，执行添加操作
    //4.通讯录中存在、文件中不存在的成员，执行删除操作。出于安全考虑，这两种情形:
    //a) 需要删除的成员多于50人，且多于现有人数的20%以上
    //b) 需要删除的成员少于50人，且多于现有人数的80%以上
    //系统将中止导入并返回相应的错误码
    //5.成员字段更新规则：可自行添加扩展字段。文件中有指定的字段，以指定的字段值为准；文件中没指定的字段，不更新
    /// </summary>
    [Serializable]
    [DataContract]
    [HttpMethod(Method = HttpVerb.Post, Url = "https://qyapi.weixin.qq.com/cgi-bin/batch/replaceuser", Name = "全量覆盖成员", IsToken = true, Serialize = SerializeVerb.Json)]
    public class BatchReplaceUserRequest : IWeiXinRequest<BatchReplaceUserResponse>
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
        public bool ToInvite { get; set; }
        /// <summary>
        /// 回调信息。如填写该项则任务完成后，通过callback推送事件给企业。具体请参考应用回调模式中的相应选项
        /// </summary>
        [DataMember(Name = "callback")]
        public CallbackEntity Callback { get; set; }
    }
}

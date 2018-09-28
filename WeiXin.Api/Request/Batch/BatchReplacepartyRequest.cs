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
    /// 全量覆盖部门
    ///1.文件中存在、通讯录中也存在的部门，执行修改操作
    ///2.文件中存在、通讯录中不存在的部门，执行添加操作
    ///3.文件中不存在、通讯录中存在的部门，当部门下没有任何成员或子部门时，执行删除操作
    ///4.CSV文件中，部门名称、部门ID、父部门ID为必填字段，部门ID必须为数字，跟部门的部门id默认为1；排序为可选字段，置空或填0不修改排序, order值大的排序靠前。
    /// </summary>
    [Serializable]
    [DataContract]
    [HttpMethod(Method = HttpVerb.Post, Url = "https://qyapi.weixin.qq.com/cgi-bin/batch/replaceparty", Name = "全量覆盖部门", IsToken = true, Serialize = SerializeVerb.Json)]
    public class BatchReplacePartyRequest: IWeiXinRequest<BatchReplacePartyResponse>
    {
        /// <summary>
        /// 上传的csv文件的media_id
        /// </summary>
        [DataMember(Name = "media_id")]
        public string MediaId { get; set; }
        /// <summary>
        /// 回调信息。如填写该项则任务完成后，通过callback推送事件给企业。具体请参考应用回调模式中的相应选项
        /// </summary>
        [DataMember(Name = "callback")]
        public CallbackEntity Callback { get; set; }
    }
}

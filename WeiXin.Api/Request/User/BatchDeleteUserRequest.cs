using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Response;
using Qhyhgf.WeiXin.Qy.Api.Attribute;

namespace Qhyhgf.WeiXin.Qy.Api.Request
{
    /// <summary>
    /// 批量删除成员
    /// </summary>
    [Serializable]
    [DataContract]
    [HttpMethod(Method = HttpVerb.Post, Url = "https://qyapi.weixin.qq.com/cgi-bin/user/batchdelete", Name = "批量删除成员", IsToken = true, Serialize = SerializeVerb.Json)]
    public class BatchDeleteUserRequest : IWeiXinRequest<BatchDeleteUserResponse>
    {
        public BatchDeleteUserRequest() {
            UseridList =new List<string>();
        }
        /// <summary>
        /// 员工UserID列表。对应管理端的帐号
        /// </summary>
        [DataMember(Name = "useridlist", IsRequired = true)]
        public IList<string> UseridList { get; set; }
    }
}

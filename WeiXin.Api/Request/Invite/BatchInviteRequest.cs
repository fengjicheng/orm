using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Qhyhgf.WeiXin.Qy.Api.Response;
using Qhyhgf.WeiXin.Qy.Api.Attribute;
using System.Runtime.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.Request
{
    /// <summary>
    /// 邀请成员
    /// </summary>
    [Serializable]
    [DataContract]
    [HttpMethod(Method = HttpVerb.Post,Url = "https://qyapi.weixin.qq.com/cgi-bin/batch/invite", Name = "邀请成员", IsToken= true,Serialize=SerializeVerb.Json)]
    public class BatchInviteRequest : IWeiXinRequest<BatchInviteResponse>
    {
        /// <summary>
        /// 成员ID列表, 最多支持1000个。
        /// </summary>
        [DataMember(Name = "user", IsRequired = false)]
        public IList<string> User { get; set; }
        /// <summary>
        /// 部门ID列表，最多支持100个。
        /// </summary>
        [DataMember(Name = "party", IsRequired = false)]
        public IList<int> Party { get; set; }
        /// <summary>
        /// 标签ID列表，最多支持100个。
        /// </summary>
        [DataMember(Name = "tag", IsRequired = false)]
        public IList<int> Tag { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Attribute;
using Qhyhgf.WeiXin.Qy.Api.Response;

namespace Qhyhgf.WeiXin.Qy.Api.Request
{
    /// <summary>
    /// 删除标签成员
    /// </summary>
    [Serializable]
    [DataContract]
    [HttpMethod(Method = HttpVerb.Post, Url = "https://qyapi.weixin.qq.com/cgi-bin/tag/deltagusers", Name = "删除标签成员", IsToken = true, Serialize = SerializeVerb.Json)]
    public class DelTagusersTagRequest : IWeiXinRequest<DelTagusersTagResponse>
    {
        /// <summary>
        /// 标签ID
        /// </summary>
        [DataMember(Name = "tagid", IsRequired = true)]
        public string TagId { get; set; }
        /// <summary>
        /// 企业员工ID列表，注意：userlist、partylist不能同时为空
        /// </summary>
        [DataMember(Name = "userlist")]
        public IList<string> UserList { get; set; }
        /// <summary>
        /// 企业部门ID列表，注意：userlist、partylist不能同时为空
        /// </summary>
        [DataMember(Name = "DataMember")]
        public IList<int> PartyList { get; set; }
    }
}

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
    /// 获取部门成员(详情)
    /// </summary>
    [Serializable]
    [DataContract]
    [HttpMethod(Method = HttpVerb.Get, Url = "https://qyapi.weixin.qq.com/cgi-bin/user/list", Name = "获取部门成员(详情)", IsToken = true, Serialize = SerializeVerb.Json)]
    public class GetUserListRequest : IWeiXinRequest<GetUserListResponse>
    {
        /// <summary>
        /// 获取的部门id
        /// </summary>
        [DataMember(Name = "department_id", IsRequired = true)]
        public int DepartmentId { get; set; }
        /// <summary>
        /// 1/0：是否递归获取子部门下面的成员
        /// </summary>
        [DataMember(Name = "fetch_child")]
        public int FetchChild { get; set; }
    }
}

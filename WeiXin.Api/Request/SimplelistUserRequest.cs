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
    /// 获取部门成员
    /// </summary>
    [HttpMethod(Method = HttpVerb.Get, Url = "https://qyapi.weixin.qq.com/cgi-bin/user/simplelist", Name = "获取部门成员", IsToken = true, Serialize = SerializeVerb.Json)]
    public class SimplelistUserRequest : IWeiXinRequest<SimplelistUserResponse>
    {
        /// <summary>
        /// 获取的部门id
        /// </summary>
        [DataMember(Name = "department_id", IsRequired = true)]
        public string DepartmentId { get; set; }
        /// <summary>
        /// 1/0：是否递归获取子部门下面的成员
        /// </summary>
        [DataMember(Name = "fetch_child", IsRequired = false)]
        public string FetchChild { get; set; }
    }
}

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
    /// 获取部门列表
    /// </summary>
    [HttpMethod(Method = HttpVerb.Get, Url = "https://qyapi.weixin.qq.com/cgi-bin/department/list", Name = "获取部门列表", IsToken = true, Serialize = SerializeVerb.None)]
    public class GetListDepartmentRequest : IWeiXinRequest<GetListDepartmentResponse>
    {
        /// <summary>
        /// 部门ID。获取指定部门ID下的子部门
        /// </summary>
        [DataMember(Name = "id",IsRequired=false)]
        public string Id { get; set; }
    }
}

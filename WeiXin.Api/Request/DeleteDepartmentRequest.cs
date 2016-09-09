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
    /// 删除部门
    /// </summary>
    [HttpMethod(Method = HttpVerb.Get, Url = "https://qyapi.weixin.qq.com/cgi-bin/department/delete", Name = "删除部门", IsToken = true,Serialize=SerializeVerb.None)]
    public class DeleteDepartmentRequest:IWeiXinRequest<DeleteDepartmentResponse>
    {
        /// <summary>
        /// 部门ID
        /// </summary>
        [DataMember(Name = "id", IsRequired = true)]
        public int ID { get; set; }

    }
}

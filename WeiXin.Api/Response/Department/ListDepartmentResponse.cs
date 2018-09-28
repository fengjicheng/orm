using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Domain;

namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    /// <summary>
    /// 获取部门列表
    /// </summary>
    public class ListDepartmentResponse:WeiXinResponse
    {
        [DataMember(Name = "department")]
        public List<DepartmentEntity> DepartmentsContent { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    /// <summary>
    /// 创建部门
    /// </summary>
    public class CreateDepartmentResponse : WeiXinResponse
    {
        /// <summary>
        /// 创建的部门id
        /// </summary>
        [DataMember(Name = "id")]
        public int ID { get; set; }
    }
}

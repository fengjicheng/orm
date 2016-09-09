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
    /// 创建部门
    /// </summary>
    [Serializable]
    [DataContract]
    [HttpMethod(Method = HttpVerb.Post,Url = "https://qyapi.weixin.qq.com/cgi-bin/department/create", Name = "创建部门",IsToken= true,Serialize=SerializeVerb.Json)]
    public class CreateDepartmentRequest : IWeiXinRequest<CreateDepartmentResponse>
    {
        /// <summary>
        /// 部门名称。长度限制为1~64个字符
        /// </summary>
        [DataMember(Name = "name", IsRequired = true)]
        public string Name { get; set; }
        /// <summary>
        /// 父亲部门id。根部门id为1
        /// </summary>
        [DataMember(Name = "parentid", IsRequired = true)]
        public string ParentId { get; set; }
        /// <summary>
        /// 在父部门中的次序。从1开始，数字越大排序越靠后
        /// </summary>
        [DataMember(Name = "order", IsRequired = false)]
        public string Order { get; set; }
    }
}

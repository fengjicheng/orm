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
    /// 更新部门
    /// </summary>
    [Serializable]
    [DataContract]
    [HttpMethod(Method = HttpVerb.Post, Url = "https://qyapi.weixin.qq.com/cgi-bin/department/update", Name = "更新部门", IsToken = true, Serialize = SerializeVerb.Json)]
    public class UpdateDepartmentRequest:IWeiXinRequest<CreateDepartmentResponse>
    {
        /// <summary>
        /// 部门id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true)]
        public int ID { get; set; }
        /// <summary>
        /// 部门名称。长度限制为1~64个字节，字符不能包括\:?”<>｜
        /// </summary>
        [DataMember(Name = "name",IsRequired=false)]
        public string Name { get; set; }
        /// <summary>
        /// 父亲部门id。根部门id为1
        /// </summary>
        [DataMember(Name = "parentid",IsRequired=false)]
        public int ParentId { get; set;}
        /// <summary>
        /// 在父部门中的次序值。order值大的排序靠前。有效的值范围是[0, 2^32)
        /// </summary>
        [DataMember(Name = "order",IsRequired=false)]
        public int Order { get; set; }
    }
}

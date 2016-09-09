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
        /// 更新的部门名称。长度限制为1~64个字符。修改部门名称时指定该参数
        /// </summary>
        [DataMember(Name = "name",IsRequired=false)]
        public string Name { get; set; }
        /// <summary>
        /// 父亲部门id。根部门id为1
        /// </summary>
        [DataMember(Name = "parentid",IsRequired=false)]
        public string ParentId { get; set;}
        /// <summary>
        /// 在父部门中的次序。从1开始，数字越大排序越靠后
        /// </summary>
        [DataMember(Name = "order",IsRequired=false)]
        public string Order { get; set; }
    }
}

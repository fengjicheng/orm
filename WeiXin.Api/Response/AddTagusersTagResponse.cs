using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    /// <summary>
    /// 增加标签成员
    /// </summary>
    public class AddTagusersTagResponse:WeiXinResponse
    {
        /// <summary>
        /// 不在权限内的员工ID列表，以“|”分隔
        /// </summary>
       [DataMember(Name = "invalidlist")]
        public string InvalidList { get; set; }
        /// <summary>
       /// 不在权限内的部门ID列表
        /// </summary>
       [DataMember(Name = "invalidparty")]
       public IList<int> InvalidPartyContent { get; set; }
    }
}

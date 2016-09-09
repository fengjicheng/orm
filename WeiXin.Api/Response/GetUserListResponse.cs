using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Domain;
namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    /// <summary>
    /// 获取部门成员(详情)
    /// </summary>
    public class GetUserListResponse:WeiXinResponse
    {
        /// <summary>
        /// 用户列表
        /// </summary>
        [DataMember(Name = "userid", IsRequired = true)]
        public List<UserItemEntity> userlist { get; set; }
    }
}

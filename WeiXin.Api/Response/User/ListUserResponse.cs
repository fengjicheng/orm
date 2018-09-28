using Qhyhgf.WeiXin.Qy.Api.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    /// <summary>
    /// 获取部门成员详情
    /// </summary>
    public class ListUserResponse:WeiXinResponse
    {
        /// <summary>
        /// 用户列表
        /// </summary>
        [DataMember(Name = "userlist")]
        public IList<UserInfoEntity> InvalidPartyContent { get; set; }
    }
}

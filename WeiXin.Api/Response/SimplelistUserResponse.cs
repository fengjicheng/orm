using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Domain;

namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    /// <summary>
    /// 获取部门成员
    /// </summary>
    public class SimplelistUserResponse : WeiXinResponse
    {
        /// <summary>
        /// 成员信息
        /// </summary>
        [DataMember(Name = "userlist", IsRequired = false)]
        public Users UsersContent { get; set; }
    }
}

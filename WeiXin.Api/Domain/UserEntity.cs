using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    /// <summary>
    /// 用户简单属性
    /// </summary>
    [Serializable]
    [DataContract]
    public class UserEntity
    {
        /// <summary>
        /// 成员名称
        /// </summary>
        [DataMember(Name = "name", IsRequired = true)]
        public string Name { get; set; }
        /// <summary>
        /// 员工UserID。对应管理端的帐号
        /// </summary>
        [DataMember(Name = "userid", IsRequired = true)]
        public string UserId { get; set; }
    }
    /// <summary>
    /// 用户列表
    /// </summary>
    [Serializable]
    [DataContract]
    public class Users
    {
        /// <summary>
        /// 成员列表
        /// </summary>
        [DataMember(Name = "userlist", IsRequired = false)]
        public IList<UserEntity> AttrsContent { get; set; }
    }
}

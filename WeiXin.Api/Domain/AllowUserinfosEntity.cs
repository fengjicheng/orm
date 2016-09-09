using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    /// <summary>
    /// 企业应用可见范围（人员）
    /// </summary>
    [Serializable]
    [DataContract]
    public class AllowUserinfosEntity
    {
        [DataMember(Name = "user", IsRequired = false)]
        public IList<UserStatus> UserStatusContent { get; set; }
    }
    /// <summary>
    /// 用户状态
    /// </summary>
    [Serializable]
    [DataContract]
    public class UserStatus
    {
        /// <summary>
        /// 用户id
        /// </summary>
        [DataMember(Name = "userid")]
        public string UserId { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        [DataMember(Name = "state")]
        public string State { get; set; }
    }
}

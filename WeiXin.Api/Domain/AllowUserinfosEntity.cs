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
        public IList<UserEntity> UserStatusContent { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    /// <summary>
    /// 企业应用可见范围（部门）
    /// </summary>
    [Serializable]
    [DataContract]
    public class AllowPartysEntity
    {
        [DataMember(Name = "partyid", IsRequired = false)]
        public IList<int> PartyIdContent { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    /// <summary>
    /// 企业应用可见范围（标签）
    /// </summary>
    [Serializable]
    [DataContract]
    public class AllowTagsEntity
    {
        [DataMember(Name = "tagid", IsRequired = false)]
        public IList<int> TagIdContent { get; set; }
    }
}

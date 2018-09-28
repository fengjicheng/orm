using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    /// <summary>
    /// 扩展属性
    /// </summary>
    [Serializable]
    [DataContract]
    public  class AttrsEntity
    {
        /// <summary>
        /// 属性名
        /// </summary>
        [DataMember(Name = "name",IsRequired=true)]
        public string Name { get; set; }
        /// <summary>
        /// 属性值
        /// </summary>
        [DataMember(Name = "value",IsRequired=true)]
        public string Value { get; set; }
    }
    /// <summary>
    /// 扩展属性添加方法
    /// </summary>
    [Serializable]
    [DataContract]
    public class Attrs {
      [DataMember(Name = "attrs", IsRequired = true)]
       public IList<AttrsEntity> AttrsContent { get; set; }
    }
}

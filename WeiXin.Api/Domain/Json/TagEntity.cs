using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    /// <summary>
    /// 标签基本信息
    /// </summary>
    [Serializable]
    [DataContract]
    public class TagEntity
    {
        /// <summary>
        /// 标签ID
        /// </summary>
        [DataMember(Name = "tagid")]
        public int TagId { get; set; }
        /// <summary>
        /// 标签名称
        /// </summary>
        [DataMember(Name = "tagname")]
        public string tagname { get; set; }
    }
    /// <summary>
    /// 标签组
    /// </summary>
    public class Tags
    {
        /// <summary>
        /// 标签列表列表
        /// </summary>
        [DataMember(Name = "taglist", IsRequired = false)]
        public IList<TagEntity> TagContent { get; set; }
    }
}

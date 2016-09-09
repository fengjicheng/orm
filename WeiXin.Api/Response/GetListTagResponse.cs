using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Domain;
namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    /// <summary>
    /// 获取标签列表
    /// </summary>
    public class GetListTagResponse : WeiXinResponse
    {
        /// <summary>
        /// 标签列表
        /// </summary>
        [DataMember(Name = "taglist", IsRequired = false)]
        public IList<TagEntity> TagContent { get; set; }
    }
}

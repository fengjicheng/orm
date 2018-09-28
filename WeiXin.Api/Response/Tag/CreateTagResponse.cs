using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    /// <summary>
    /// 创建标签
    /// </summary>
    public class CreateTagResponse : WeiXinResponse
    {
        /// <summary>
        /// 创建的ID
        /// </summary>
        [DataMember(Name = "tagid")]
        public string TagId { get; set; }
    }
}

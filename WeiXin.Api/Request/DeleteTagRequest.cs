using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Attribute;
using Qhyhgf.WeiXin.Qy.Api.Response;

namespace Qhyhgf.WeiXin.Qy.Api.Request
{
    /// <summary>
    /// 删除标签
    /// </summary>
    [HttpMethod(Method = HttpVerb.Get, Url = "https://qyapi.weixin.qq.com/cgi-bin/tag/delete", Name = "删除标签", IsToken = true, Serialize = SerializeVerb.Json)]
    public class DeleteTagRequest : IWeiXinRequest<DeleteTagResponse>
    {
        /// <summary>
        /// 标签ID
        /// </summary>
        [DataMember(Name = "tagid", IsRequired = true)]
        public string TagId { get; set; }
    }
}

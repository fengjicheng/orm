using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Qhyhgf.WeiXin.Qy.Api.Response;
using Qhyhgf.WeiXin.Qy.Api.Attribute;
using System.Runtime.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.Request
{
    /// <summary>
    /// 获取标签成员
    /// </summary>
    [HttpMethod(Method = HttpVerb.Get, Url = "https://qyapi.weixin.qq.com/cgi-bin/tag/get", Name = "获取标签成员", IsToken = true, Serialize = SerializeVerb.Json)]
    public class GetTagRequest : IWeiXinRequest<GetTagResponse>
    {
        /// <summary>
        /// 标签ID
        /// </summary>
        [DataMember(Name = "tagid", IsRequired = true)]
        public string TagId { get; set; }
    }
}

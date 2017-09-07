using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Qhyhgf.WeiXin.Qy.Api.Attribute;
using Qhyhgf.WeiXin.Qy.Api.Response;

namespace Qhyhgf.WeiXin.Qy.Api.Request
{
    /// <summary>
    /// 获取标签列表
    /// </summary>
    [HttpMethod(Method = HttpVerb.Get, Url = "https://qyapi.weixin.qq.com/cgi-bin/tag/list", Name = "获取标签列表", IsToken = true, Serialize = SerializeVerb.Json)]
    public class ListTagRequest : IWeiXinRequest<ListTagResponse>
    {
    }
}

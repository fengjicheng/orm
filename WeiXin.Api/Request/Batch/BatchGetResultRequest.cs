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
    ///获取异步任务结果
    /// </summary>
    [HttpMethod(Method = HttpVerb.Get, Url = "https://qyapi.weixin.qq.com/cgi-bin/user/authsucc", Name = "获取异步任务结果", IsToken = true, Serialize = SerializeVerb.Json)]
    public class BatchGetResultRequest : IWeiXinRequest <BatchGetResultResponse>
    {
        /// <summary>
        ///异步任务id，最大长度为64字节
        /// </summary>
        [DataMember(Name = "jobid", IsRequired = true)]
        public string JobId { get; set; }
    }
}

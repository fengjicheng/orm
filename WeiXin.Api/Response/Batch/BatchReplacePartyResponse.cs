using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    /// <summary>
    /// 批量更新部门
    /// </summary>
    public class BatchReplacePartyResponse : WeiXinResponse
    {
        [DataMember(Name = "jobid")]
        public string JobId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    /// <summary>
    /// 批量增量更新成员
    /// </summary>
    public class BatchSyncuserResponse : WeiXinResponse
    {
        [DataMember(Name = "jobid")]
        public string JobId { get; set; }
    }
}

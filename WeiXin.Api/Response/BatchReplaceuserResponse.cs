using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    public class BatchReplaceuserResponse : WeiXinResponse
    {
        [DataMember(Name = "jobid")]
        public string JobId { get; set; }
    }
}

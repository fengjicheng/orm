using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Qhyhgf.WeiXin.Qy.Api.Domain;

namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    public class AgentListResponse : WeiXinResponse
    {
        [DataMember(Name = "agentlist", IsRequired = false)]
        public IList<AgentEntity> AgentEntityContent { get; set; }
    }
}

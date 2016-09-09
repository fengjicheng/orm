using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    /// <summary>
    /// 获取微信服务器的ip段
    /// </summary>
    public class GetCallbackIpResponse:WeiXinResponse
    {
        [DataMember(Name = "ip_list")]
        public List<string> IpList { get; set; }
    }
}

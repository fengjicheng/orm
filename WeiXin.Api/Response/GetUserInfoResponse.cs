using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    /// <summary>
    /// 根据code获取成员信息
    /// </summary>
    public class GetUserInfoResponse : WeiXinResponse
    {
        [DataMember(Name = "UserId")]
        public string UserId { get; set; }
        [DataMember(Name = "DeviceId")]
        public string DeviceId { get; set; }
    }
}

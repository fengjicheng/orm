using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    /// <summary>
    /// 根据code获取成员信息
    /// </summary>
    public class UserGetuserinfoResponse : WeiXinResponse
    {
        /// <summary>
        /// 员工UserID
        /// </summary>
        [DataMember(Name = "UserId")]
        public string UserId { get; set; }
        /// <summary>
        /// 手机设备号(由微信在安装时随机生成)
        /// </summary>
        [DataMember(Name = "DeviceId")]
        public string DeviceId { get; set; }
    }
}

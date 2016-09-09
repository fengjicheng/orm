using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    /// <summary>
    /// 邀请成员关注
    /// </summary>
    public class SendInviteResponse : WeiXinResponse
    {

        /// <summary>
        /// 1:微信邀请 2.邮件邀请
        /// </summary>
        [DataMember(Name = "type")]
        public int Type { get; set; }
    }
}

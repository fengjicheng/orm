using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    /// <summary>
    /// 主动发送消息
    /// </summary>
    public class SendMessageResponse : WeiXinResponse
    {
        /// <summary>
        /// 收件人
        /// </summary>
        [DataMember(Name = "invaliduser")]
        public string InvalidUser { get; set; }
        /// <summary>
        /// 部门
        /// </summary>
        [DataMember(Name = "invalidparty")]
        public string InvalidParty { get; set; }
        /// <summary>
        /// 标签
        /// </summary>
        [DataMember(Name = "invalidtag")]
        public string InvalidTag { get; set; }
    }
}

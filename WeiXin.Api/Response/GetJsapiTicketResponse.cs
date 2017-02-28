using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    /// <summary>
    /// 获得jsapi_ticket
    /// </summary>
    public class GetJsapiTicketResponse: WeiXinResponse
    {
        /// 成员列表
        /// </summary>
        [DataMember(Name = "ticket")]
        public string Ticket { get; set; }
        /// 成员列表
        /// </summary>
        [DataMember(Name = "expires_in")]
        public int ExpiresIn { get; set; }
    }
}

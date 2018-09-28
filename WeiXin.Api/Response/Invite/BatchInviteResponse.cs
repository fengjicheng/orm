using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    /// <summary>
    /// 邀请成员
    /// </summary>
    public class BatchInviteResponse : WeiXinResponse
    {
        /// <summary>
        /// 非法成员列表
        /// </summary>
        [DataMember(Name = "invaliduser")]
        public IList<string> InvalidUser { get; set; }
        /// <summary>
        /// 非法部门列表
        /// </summary>
        [DataMember(Name = "invalidparty")]
        public IList<int> InvalidParty { get; set; }
        /// <summary>
        /// 非法标签列表
        /// </summary>
        [DataMember(Name = "invalidtag")]
        public IList<int> InvalidTag { get; set; }

    }
}

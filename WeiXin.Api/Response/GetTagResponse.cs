using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Domain;

namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    /// <summary>
    /// 获取标签成员
    /// </summary>
    public class GetTagResponse:WeiXinResponse
    {
        /// <summary>
        /// 成员列表
        /// </summary>
        [DataMember(Name = "userlist")]
        public IList<UserEntity> UserContent { get; set; }
        /// <summary>
        /// 部门列表
        /// </summary>
        [DataMember(Name = "partylist")]
        public IList<int> PartyContent { get; set; }
    }
}

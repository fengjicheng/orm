using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    /// <summary>
    /// openid转换成userid接口
    /// </summary>
    public class ConvertToUseridResponse : WeiXinResponse
    {
        /// <summary>
        /// 企业号成员userid对应的openid，若有传参agentid，则是针对该agentid的openid。否则是针对企业号corpid的openid
        /// </summary>
        [DataMember(Name = "userid")]
        public string UserId { get; set; }
    }
}

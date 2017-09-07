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
        /// 该openid在企业中对应的成员userid
        /// </summary>
        [DataMember(Name = "userid")]
        public string UserId { get; set; }
    }
}

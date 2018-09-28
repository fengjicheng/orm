using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    /// <summary>
    /// userid转换成openid接口
    /// </summary>
    public class ConvertToOpenidResponse: WeiXinResponse
    {
        /// <summary>
        /// 企业号成员userid对应的openid，若有传参agentid，则是针对该agentid的openid。否则是针对企业号corpid的openid
        /// </summary>
        [DataMember(Name = "openid")]
        public string Openid { get; set; }
    }
}

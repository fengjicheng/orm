using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    /// <summary>
    /// 回调实体
    /// </summary>
    [Serializable]
    [DataContract]
    public class CallbackEntity
    {
        /// <summary>
        /// 企业应用接收企业号推送请求的访问协议和地址，支持http或https协议
        /// </summary>
        [DataMember(Name = "url")]
        public string Url { get; set; }
        /// <summary>
        /// 用于生成签名
        /// </summary>
        [DataMember(Name = "token")]
        public string Token { get; set; }
        /// <summary>
        ///用于消息体的加密，是AES密钥的Base64编码
        /// </summary>
        [DataMember(Name = "encodingaeskey")]
        public string Encodingaeskey { get; set; }
    }
}

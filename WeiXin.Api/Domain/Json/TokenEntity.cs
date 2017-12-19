using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    /// <summary>
    /// 请求基类
    /// </summary>
    [Serializable]
    [DataContract]
    public class TokenEntity : WeiXinResponse
    {
        [DataMember(Name = "access_token", IsRequired = false)]
        public string AccessToken { get; set; }
         [DataMember(Name = "expires_in", IsRequired = false)]
        public int ExpiresIn { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Attribute;
using Qhyhgf.WeiXin.Qy.Api.Response;

namespace Qhyhgf.WeiXin.Qy.Api.Request
{
    /// <summary>
    /// 更新标签名字
    /// </summary>
    [Serializable]
    [DataContract]
    [HttpMethod(Method = HttpVerb.Post, Url = "https://qyapi.weixin.qq.com/cgi-bin/tag/update", Name = "更新标签名字", IsToken = true, Serialize = SerializeVerb.Json)]
    public class UpdateTagRequest : IWeiXinRequest<UpdateTagResponse>
    {
        /// <summary>
        /// 标签ID
        /// </summary>
       [DataMember(Name = "tagid", IsRequired = true)]
        public string TagId { get; set; }
        /// <summary>
       /// 标签名称。长度为1~64个字符，标签不可与其他同组的标签重名，也不可与全局标签重名
        /// </summary>
        [DataMember(Name = "tagname",IsRequired=true)]
       public string TagName { get; set; }
    }
}

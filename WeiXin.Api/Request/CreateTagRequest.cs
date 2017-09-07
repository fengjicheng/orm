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
    /// 创建标签
    /// </summary>
    [Serializable]
    [DataContract]
    [HttpMethod(Method = HttpVerb.Post, Url = "https://qyapi.weixin.qq.com/cgi-bin/tag/create", Name = "创建标签", IsToken = true, Serialize = SerializeVerb.Json)]
    public class CreateTagRequest : IWeiXinRequest<CreateTagResponse>
    {
        /// <summary>
        /// 标签名称，长度限制为32个字（汉字或英文字母），标签名不可与其他标签重名。
        /// </summary>
        [DataMember(Name = "tagname", IsRequired = true)]
        public string TagName { get; set; }
        /// <summary>
        /// 标签id，非负整型，指定此参数时新增的标签会生成对应的标签id，不指定时则以目前最大的id自增。
        /// </summary>
        [DataMember(Name = "tagid", IsRequired = true)]
        public int tagid { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Qhyhgf.WeiXin.Qy.Api.Attribute;
using Qhyhgf.WeiXin.Qy.Api.Response;
using System.Runtime.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Domain;

namespace Qhyhgf.WeiXin.Qy.Api.Request
{
    /// <summary>
    /// 更新成员
    /// </summary>
    [Serializable]
    [DataContract]
    [HttpMethod(Method = HttpVerb.Post, Url = "https://qyapi.weixin.qq.com/cgi-bin/user/update", Name = "更新成员", IsToken = true, Serialize = SerializeVerb.Json)]
    public class UpdateUserRequest : IWeiXinRequest<UpdateUserResponse>
    { /// <summary>
        /// 员工UserID。对应管理端的帐号，企业内必须唯一。长度为1~64个字符
        /// </summary>
        [DataMember(Name = "userid", IsRequired = true)]
        public string UserId { get; set; }
        /// <summary>
        /// 成员名称。长度为1~64个字符
        /// </summary>
        [DataMember(Name = "name", IsRequired = true)]
        public string Name { get; set; }
        /// <summary>
        /// 成员所属部门id列表。注意，每个部门的直属员工上限为1000个
        /// </summary>
        [DataMember(Name = "department")]
        public IList<int> Department { get; set; }
        /// <summary>
        /// 职位信息。长度为0~64个字符
        /// </summary>
        [DataMember(Name = "position")]
        public string Position { get; set; }
        /// <summary>
        /// 手机号码。企业内必须唯一，mobile/weixinid/email三者不能同时为空
        /// </summary>
        [DataMember(Name = "mobile")]
        public string Mobile { get; set; }
        /// <summary>
        /// 邮箱。长度为0~64个字符。企业内必须唯一
        /// </summary>
        [DataMember(Name = "email")]
        public string Email { get; set; }
        /// <summary>
        /// 微信号。企业内必须唯一。（注意：是微信号，不是微信的名字）
        /// </summary>
        [DataMember(Name = "weixinid")]
        public string WeixinId { get; set; }
        /// <summary>
        /// 启用/禁用成员。1表示启用成员，0表示禁用成员
        /// </summary>
        [DataMember(Name = "enable")]
        public int Enable { get; set; }
        /// <summary>
        /// 扩展属性。扩展属性需要在WEB管理端创建后才生效，否则忽略未知属性的赋值
        /// </summary>
        [DataMember(Name = "extattr")]
        public Attrs ExtAttr { get; set; }
    }
}

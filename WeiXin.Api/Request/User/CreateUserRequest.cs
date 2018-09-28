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
    /// 创建成员
    /// </summary>
    [Serializable]
    [DataContract]
    [HttpMethod(Method = HttpVerb.Post, Url = "https://qyapi.weixin.qq.com/cgi-bin/user/create", Name = "创建成员", IsToken = true, Serialize = SerializeVerb.Json)]
    public class CreateUserRequest : IWeiXinRequest<CreateUserResponse>
    {
        public CreateUserRequest() {
            Enable = 1;
        }
        /// <summary>
        /// 成员UserID。对应管理端的帐号，企业内必须唯一。不区分大小写，长度为1~64个字节
        /// </summary>
        [DataMember(Name = "userid", IsRequired = true)]
        public string UserId { get; set; }
        /// <summary>
        /// 成员名称。长度为1~64个字符
        /// </summary>
        [DataMember(Name = "name",IsRequired= true)]
        public string Name { get; set; }
        /// <summary>
        /// 成员别名。长度1~32个字符
        /// </summary>
        [DataMember(Name = "alias", IsRequired = false)]
        public string Alias { get; set; }
        /// <summary>
        /// 手机号码。企业内必须唯一，mobile/email二者不能同时为空
        /// </summary>
        [DataMember(Name = "mobile", IsRequired = false)]
        public string Mobile { get; set; }
        /// <summary>
        /// 成员所属部门id列表,不超过20个
        /// </summary>
        [DataMember(Name = "department",IsRequired=false)]
        public IList<int> Department { get; set; }
        /// <summary>
        /// 部门内的排序值，默认为0。数量必须和department一致，数值越大排序越前面。有效的值范围是[0, 2^32)
        /// </summary>
        [DataMember(Name = "order", IsRequired = false)]
        public List<int> Order { get; set; }
        /// <summary>
        /// 职位信息。长度为0~64个字符
        /// </summary>
        [DataMember(Name = "position", IsRequired = false)]
        public string Position { get; set; }
        /// <summary>
        /// 性别。1表示男性，2表示女性
        /// </summary>
        [DataMember(Name = "gender", IsRequired = false)]
        public int Gender { get; set; }
        /// <summary>
        /// 邮箱。长度为0~64个字符。企业内必须唯一
        /// </summary>
        [DataMember(Name = "email", IsRequired = false)]
        public string Email { get; set; }
        /// <summary>
        /// 座机。长度0-64个字节。
        /// </summary>
        [DataMember(Name = "telephone", IsRequired = false)]
        public string Telephone { get; set; }
        /// <summary>
        /// 上级字段，标识是否为上级。
        /// </summary>
        [DataMember(Name = "isleader", IsRequired = false)]
        public int IsLeader { get; set; }
        /// <summary>
        /// 成员头像的mediaid，通过多媒体接口上传图片获得的mediaid
        /// </summary>
        [DataMember(Name = "avatar_mediaid", IsRequired = false)]
        public string AvatarMediaid { get; set; }
        /// <summary>
        /// 启用/禁用成员。1表示启用成员，0表示禁用成员
        /// </summary>
        [DataMember(Name = "enable", IsRequired = false)]
        public int Enable { get; set; }
        /// <summary>
        /// 自定义字段。自定义字段需要先在WEB管理端添加，见扩展属性添加方法，否则忽略未知属性的赋值。自定义字段长度为0~32个字符，超过将被截断
        /// </summary>
        [DataMember(Name = "extattr", IsRequired = false)]
        public Attrs ExtAttr { get; set; }
        /// <summary>
        /// 是否邀请该成员使用企业微信（将通过微信服务通知或短信或邮件下发邀请，每天自动下发一次，最多持续3个工作日），默认值为true。
        /// </summary>
        [DataMember(Name = "to_invite", IsRequired = false)]
        public bool ToInvite { get; set; }
        /// <summary>
        /// 对外职务，如果设置了该值，则以此作为对外展示的职务，否则以position来展示。长度12个汉字内
        /// </summary>
        [DataMember(Name = "external_position", IsRequired = false)]
        public string ExternalPosition { get; set; }

    }
}

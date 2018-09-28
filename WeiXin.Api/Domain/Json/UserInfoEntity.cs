using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    /// <summary>
    /// 用户详细信息
    /// </summary>
    [Serializable]
    [DataContract]
    public class UserInfoEntity
    {
        /// <summary>
        /// 成员UserID。对应管理端的帐号，企业内必须唯一。不区分大小写，长度为1~64个字节
        /// </summary>
        [DataMember(Name = "userid", IsRequired = true)]
        public string UserId { get; set; }
        /// <summary>
        /// 成员名称。长度为1~64个字符
        /// </summary>
        [DataMember(Name = "name", IsRequired = true)]
        public string Name { get; set; }
        /// <summary>
        /// 手机号码。企业内必须唯一，mobile/email二者不能同时为空
        /// </summary>
        [DataMember(Name = "mobile", IsRequired = false)]
        public string Mobile { get; set; }
        /// <summary>
        /// 成员所属部门id列表,不超过20个
        /// </summary>
        [DataMember(Name = "department", IsRequired = false)]
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
        /// 上级字段，标识是否为上级。
        /// </summary>
        [DataMember(Name = "isleader", IsRequired = false)]
        public int IsLeader { get; set; }
        /// <summary>
        /// 头像url。注：如果要获取小图将url最后的”/0”改成”/100”即可。第三方仅通讯录应用可获取
        /// </summary>
        [DataMember(Name = "avatar", IsRequired = false)]
        public string Avatar { get; set; }
        /// <summary>
        /// 座机。长度0-64个字节。
        /// </summary>
        [DataMember(Name = "telephone", IsRequired = false)]
        public string Telephone { get; set; }
        /// <summary>
        /// 启用/禁用成员。1表示启用成员，0表示禁用成员
        /// </summary>
        [DataMember(Name = "enable", IsRequired = false)]
        public int Enable { get; set; }
        /// <summary>
        /// 别名；第三方仅通讯录应用可获取
        /// </summary>
        [DataMember(Name = "alias", IsRequired = false)]
        public string Alias { get; set; }
        /// <summary>
        /// 激活状态: 1=已激活，2=已禁用，4=未激活。
        /// 已激活代表已激活企业微信或已关注微工作台（原企业号）。未激活代表既未激活企业微信又未关注微工作台（原企业号）。
        /// </summary>
        [DataMember(Name = "status", IsRequired = false)]
        public int Status { get; set; }
        /// <summary>
        /// 员工个人二维码，扫描可添加为外部联系人；第三方仅通讯录应用可获取
        /// </summary>
        [DataMember(Name = "qr_code", IsRequired = false)]
        public string QrCode { get; set; }
        /// <summary>
        /// 对外职务，如果设置了该值，则以此作为对外展示的职务，否则以position来展示。
        /// </summary>
        [DataMember(Name = "external_position", IsRequired = false)]
        public string ExternalPosition { get; set; }
    }
}

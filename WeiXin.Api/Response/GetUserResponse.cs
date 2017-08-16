using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Domain;

namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    /// <summary>
    /// 获取成员
    /// </summary>
    public class GetUserResponse:WeiXinResponse
    {
        /// <summary>
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
        [DataMember(Name = "department", IsRequired = false)]
        public List<int> DepartmentContent { get; set; }
        /// <summary>
        /// 部门内的排序值，默认为0。数量必须和department一致，数值越大排序越前面。值范围是[0, 2^32)
        /// </summary>
        [DataMember(Name = "order", IsRequired = false)]
        public List<int> order { get; set; }
        /// <summary>
        /// 职位信息。长度为0~64个字符
        /// </summary>
        [DataMember(Name = "position", IsRequired = false)]
        public string Position { get; set; }
        /// <summary>
        /// 性别。0表示未定义，1表示男性，2表示女性
        /// </summary>
        [DataMember(Name = "gender", IsRequired = false)]
        public string Gender { get; set; }
        /// <summary>
        /// 手机号码。企业内必须唯一，mobile/weixinid/email三者不能同时为空
        /// </summary>
        [DataMember(Name = "mobile", IsRequired = false)]
        public string Mobile { get; set; }
        /// <summary>
        /// 邮箱。长度为0~64个字符。企业内必须唯一
        /// </summary>
        [DataMember(Name = "email", IsRequired = false)]
        public string Email { get; set; }
        /// <summary>
        /// 上级字段，标识是否为上级。
        /// </summary>
        [DataMember(Name = "isleader", IsRequired = false)]
        public int Isleader { get; set; }
        /// <summary>
        /// 头像url。注：如果要获取小图将url最后的"/0"改成"/64"即可
        /// </summary>
        [DataMember(Name = "avatar",IsRequired=false)]
        public string Avatar { get; set; }
        /// <summary>
        /// 座机。第三方仅通讯录套件可获取
        /// </summary>
        [DataMember(Name = "telephone", IsRequired = false)]
        public string Telephone { get; set; }
        /// <summary>
        /// 座机。第三方仅通讯录套件可获取
        /// </summary>
        [DataMember(Name = "english_name", IsRequired = false)]
        public string EnglishName { get; set; }
        /// <summary>
        /// 激活状态: 1=已激活，2=已禁用，4=未激活。
        //已激活代表已激活企业微信或已关注微信插件。未激活代表既未激活企业微信又未关注微信插件。
        /// </summary>
        [DataMember(Name = "status", IsRequired = false)]
        public int Status { get; set; }
        /// <summary>
        /// 扩展属性。扩展属性需要在WEB管理端创建后才生效，否则忽略未知属性的赋值
        /// </summary>
        [DataMember(Name = "extattr", IsRequired = false)]
        public Attrs ExtAttr { get; set; }
    }
}

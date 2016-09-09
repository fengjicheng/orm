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
        /// 职位信息。长度为0~64个字符
        /// </summary>
        [DataMember(Name = "position", IsRequired = false)]
        public string Position { get; set; }
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
        /// 微信号。企业内必须唯一。（注意：是微信号，不是微信的名字）
        /// </summary>
        [DataMember(Name = "weixinid", IsRequired = false)]
        public string WeixinId { get; set; }
        /// <summary>
        /// 头像url。注：如果要获取小图将url最后的"/0"改成"/64"即可
        /// </summary>
        [DataMember(Name = "avatar",IsRequired=false)]
        public string Avatar { get; set; }
        /// <summary>
        /// 关注状态: 1=已关注，2=已冻结，4=未关注
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

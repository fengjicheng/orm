using Qhyhgf.WeiXin.Qy.Api.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    /// <summary>
    /// 更新成员事件
    /// </summary>
    [Serializable]
    [XmlRoot("xml")]
    public class UpdateUserEvent
    {
        /// <summary>
        /// 第三方应用ID
        /// </summary>
        [XmlElement("SuiteId")]
        public CDATA<string> SuiteId { get; set; }
        /// <summary>
        /// 授权企业的CorpID
        /// </summary>
        [XmlElement("AuthCorpId")]
        public CDATA<string> AuthCorpId { get; set; }
        /// <summary>
        /// 固定为change_contact
        /// </summary>
        [XmlElement("InfoType")]
        public CDATA<string> InfoType { get; set; }
        /// <summary>
        /// 时间戳
        /// </summary>
        [XmlElement("TimeStamp")]
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// 固定为update_user
        /// </summary>
        [XmlElement("ChangeType")]
        public CDATA<string> ChangeType { get; set; }
        /// <summary>
        /// 	变更信息的成员UserID
        /// </summary>
        [XmlElement("UserID")]
        public CDATA<string> UserID { get; set; }
        /// <summary>
        /// 新的UserID，变更时推送（userid由系统生成时可更改一次）
        /// </summary>
        [XmlElement("NewUserID")]
        public CDATA<string> NewUserID { get; set; }
        /// <summary>
        /// 成员名称，变更时推送
        /// </summary>
        [XmlElement("Name")]
        public CDATA<string> Name { get; set; }
        /// <summary>
        /// 成员部门列表
        /// </summary>
        [XmlElement("Department")]
        public CDATA<List<int>> Department { get; set; }
        /// <summary>
        /// 手机号码，变更时推送，仅通讯录应用可获取
        /// </summary>
        [XmlElement("Mobile")]
        public CDATA<string> Mobile { get; set; }
        /// <summary>
        /// 职位信息。长度为0~64个字节
        /// </summary>
        [XmlElement("Position")]
        public CDATA<string> Position { get; set; }
        /// <summary>
        /// 性别，变更时推送。1表示男性，2表示女性
        /// </summary>
        [XmlElement("Gender")]
        public int Gender { get; set; }
        /// <summary>
        /// 邮箱，变更时推送 ，仅通讯录应用可获取
        /// </summary>
        [XmlElement("Email")]
        public CDATA<string> Email { get; set; }
        /// <summary>
        /// 激活状态：1=激活或关注， 2=禁用， 4=退出企业（退出企业并且取消关注时触发）
        /// </summary>
        [XmlElement("Status")]
        public int Status { get; set; }
        /// <summary>
        /// 头像url。注：如果要获取小图将url最后的”/0”改成”/100”即可。变更时推送
        /// </summary>
        [XmlElement("Avatar")]
        public CDATA<string> Avatar { get; set; }
        /// <summary>
        /// 英文名
        /// </summary>
        [XmlElement("EnglishName")]
        public CDATA<string> EnglishName { get; set; }
        /// <summary>
        /// 上级字段，标识是否为上级。0表示普通成员，1表示上级
        /// </summary>
        [XmlElement("IsLeader")]
        public int IsLeader { get; set; }
        /// <summary>
        /// 座机，仅通讯录应用可获取
        /// </summary>
        [XmlElement("Telephone")]
        public CDATA<string> Telephone { get; set; }
        /// <summary>
        /// 扩展属性，变更时推送，仅通讯录应用可获取
        /// </summary>
        [XmlArray("ExtAttr")]
        [XmlArrayItem(ElementName = "Item")]
        public List<ExtAttrEntity> ExtAttr { get; set; }
    }
}

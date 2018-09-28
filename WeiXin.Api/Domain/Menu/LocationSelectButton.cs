using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Qhyhgf.WeiXin.Qy.Api.Domain.Menu
{
    /// <summary>
    /// 弹出地理位置选择器
    /// 成员点击按钮后，微信客户端将调起地理位置选择工具，
    /// 完成选择操作后，将选择的地理位置发送给开发者的服务器，
    /// 同时收起位置选择工具，随后可能会收到开发者下发的消息。
    /// </summary>
    public class LocationSelectButton : MenuButtonBase
    {
        public LocationSelectButton() {
            Type = "location_select";
        }
        /// <summary>
        /// 菜单标题，不超过16个字节，子菜单不超过40个字节
        /// </summary>
        public override string Name
        {
            get; set;
        }
        /// <summary>
        /// 	菜单的响应动作类型
        /// </summary>
        public override string Type
        {
            get; set;
        }
        /// <summary>
        /// 菜单KEY值，用于消息接口推送，不超过128字节
        /// </summary>
        [DataMember(Name = "key")]
        public string Key { get; set; }
    }
}

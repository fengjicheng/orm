using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Qhyhgf.WeiXin.Qy.Api.Domain.Menu
{
    /// <summary>
    /// 弹出拍照或者相册发图
    /// 成员点击按钮后，微信客户端将弹出选择器供成员选择
    /// “拍照”或者“从手机相册选择”。成员选择后即走其他两种流程。
    /// </summary>
    public class PicPhotoOrAlbumEvent : MenuEventBase
    {
        public PicPhotoOrAlbumEvent() {
            Type = "pic_sysphoto";
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

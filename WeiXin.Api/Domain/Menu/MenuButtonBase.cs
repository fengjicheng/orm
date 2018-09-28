using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Qhyhgf.WeiXin.Qy.Api.Domain.Menu
{
    /// <summary>
    /// 菜单条目
    /// </summary>
    [Serializable]
    [DataContract]
    public  class MenuButtonBase
    {
        /// <summary>
        /// 菜单的响应动作类型
        /// click	点击推事件
        /// view	跳转URL
        /// scancode_push	扫码推事件
        /// scancode_waitmsg	扫码推事件 且弹出“消息接收中”提示框
        /// pic_sysphoto	弹出系统拍照发图
        /// pic_photo_or_album	弹出拍照或者相册发图
        /// pic_weixin	弹出企业微信相册发图器
        /// location_select	弹出地理位置选择器
        /// </summary>
        [DataMember(Name = "type")]
        public virtual string Type { get; set; }
        /// <summary>
        ///菜单标题，不超过16个字节，子菜单不超过40个字节
        /// </summary>
        [DataMember(Name = "name")]
        public virtual string Name { get; set; }
        /// <summary>
        /// 二级菜单数组，个数应为1~5个
        /// </summary>
        [DataMember(Name = "sub_button")]
        public IList<MenuButtonBase> SubButton { get; set; }
    }
}

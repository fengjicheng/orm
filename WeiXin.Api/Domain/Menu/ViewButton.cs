using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Qhyhgf.WeiXin.Qy.Api.Domain.Menu
{
    /// <summary>
    /// 成员点击view类型按钮后，企业微信客户端将会打开开发者在按钮中填写的网页URL，可与网页授权获取成员基本信息接口结合，获得成员基本信息。
    /// </summary>
    public class ViewButton : MenuButtonBase
    {
        public ViewButton() {
            Type = "view";
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
        /// 页链接，成员点击菜单可打开链接，不超过256字节
        /// </summary>
        [DataMember(Name = "url")]
        public string Url { get;set;}
    }
}

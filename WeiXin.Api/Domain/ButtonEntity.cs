using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    [Serializable]
    [DataContract]
    public class ButtonEntity
    {
        public ButtonEntity()
        {
            SubButton = new List<ButtonEntity>();
        }
        [DataMember(Name = "sub_button")]
        public IList<ButtonEntity> SubButton { get; set; }
        /// <summary>
        /// 菜单的响应动作类型
        /// </summary>
        [DataMember(Name = "type")]
        public EventType type { get; set; }
        /// <summary>
        /// 菜单标题，不超过16个字节，子菜单不超过40个字节
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }
        /// <summary>
        /// click等点击类型必须
        /// 菜单KEY值，用于消息接口推送，不超过128字节
        /// </summary>
        [DataMember(Name = "key")]
        public string Key { get; set; }
        /// <summary>
        /// view类型必须
        /// 网页链接，员工点击菜单可打开链接，不超过256字节
        /// </summary>
        [DataMember(Name = "url")]
        public string Url { get; set; }
    }
}

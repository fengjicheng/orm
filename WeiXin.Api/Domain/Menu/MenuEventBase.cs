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
    public  class MenuEventBase
    {
        /// <summary>
        /// 菜单的响应动作类型
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
        public IList<MenuEventBase> SubButton { get; set; }
    }
}

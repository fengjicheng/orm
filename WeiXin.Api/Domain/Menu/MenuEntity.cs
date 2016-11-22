using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.Domain.Menu
{
    [Serializable]
    [DataContract]
    public class MenuEntity
    {
        public MenuEntity()
        {
            Buttons = new List<MenuEventBase>();
        }
        [DataMember(Name = "button")]
        public IList<MenuEventBase> Buttons { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    [Serializable]
    [DataContract]
    public class MenuEntity
    {
        public MenuEntity()
        {
            Buttons = new List<ButtonEntity>();
        }
        [DataMember(Name = "button")]
        public IList<ButtonEntity> Buttons { get; set; }
    }
}

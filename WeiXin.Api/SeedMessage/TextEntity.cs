using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.SeedMessage
{
    [Serializable]
    [DataContract]
    public class TextEntity
    {
        /// <summary>
        /// 消息内容
        /// </summary>
        [DataMember(Name = "content", IsRequired = true)]
        public string Content { get; set; }
    }
}

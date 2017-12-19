using Qhyhgf.WeiXin.Qy.Api.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    /// <summary>
    /// 扩展属性
    /// </summary>
    public class ExtAttrEntity
    {
        /// <summary>
        /// KEY
        /// </summary>
        [XmlElement("Name")]
        public CDATA<string> Name { get; set; }
        /// <summary>
        /// KEY
        /// </summary>
        [XmlElement("Value")]
        public CDATA<string> Value { get; set; }
    }
}

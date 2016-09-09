using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qhyhgf.WeiXin.Qy.Api.Attribute
{
    /// <summary>
    ///请求参数(Qequest)要序列化类型;
    /// </summary>
    [Flags]
    public enum SerializeVerb:byte
    {
        /// <summary>
        /// JSON字符串
        /// </summary>
        Json = 1 << 0,
        /// <summary>
        /// XML字符串
        /// </summary>
        Xml = 1 << 1,
        /// <summary>
        /// 字节流
        /// </summary>
        Byte = 1 << 2,
        /// <summary>
        /// 不序列化直接返回
        /// </summary>
        None = 1 << 3
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qhyhgf.WeiXin.Qy.Api.Attribute
{
    /// <summary>
    /// 发送的请求类型
    /// </summary>
    [Flags]
    public enum HttpVerb:byte
    {
        /// <summary>
        /// Get请求
        /// </summary>
        Get = 1 << 0,
        /// <summary>
        /// Post请求
        /// </summary>
        Post = 1 << 1,
        /// <summary>
        /// 上传文件请求
        /// </summary>
        File = 1 << 2
    }
}

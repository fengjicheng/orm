using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    /// <summary>
    /// 多媒体类型
    /// </summary>
    public enum MediaType
    {
        /// <summary>
        /// 图片
        /// </summary>
        Image =1 << 0,
        /// <summary>
        /// 语音
        /// </summary>
        Voice = 1 << 1,
        /// <summary>
        /// 视频
        /// </summary>
        Video = 1 << 2,
        /// <summary>
        /// 普通文件
        /// </summary>
        File = 1 << 3
    }
}

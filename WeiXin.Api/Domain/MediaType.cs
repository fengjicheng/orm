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
        /// 2MB，支持JPG,PNG格式
        /// </summary>
        Image = 1 << 0,
        /// <summary>
        /// 语音
        /// 2MB，播放长度不超过60s，仅支持AMR格式
        /// </summary>
        Voice = 1 << 1,
        /// <summary>
        /// 视频
        /// 10MB，支持MP4格式
        /// </summary>
        Video = 1 << 2,
        /// <summary>
        /// 普通文件
        /// 20MB
        /// </summary>
        File = 1 << 3
    }
}

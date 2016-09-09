using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    /// <summary>
    /// 消息类型
    /// </summary>
    [Flags]
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MessageType:int
    {
        /// <summary>
        /// 事件
        /// </summary>
        [EnumMember(Value = "event")]
        Event = 1 << 0,
        /// <summary>
        /// text消息
        /// </summary>
        [EnumMember(Value = "text")]
        Text = 1 << 1,
        /// <summary>
        /// image消息
        /// </summary>
        [EnumMember(Value = "image")]
        Image = 1 << 2,
        /// <summary>
        /// voice消息
        /// </summary>
        [EnumMember(Value = "voice")]
        Voice = 1 << 3,
        /// <summary>
        /// video消息
        /// </summary>
        [EnumMember(Value = "video")]
        Video = 1 << 4,
        /// <summary>
        /// location消息
        /// </summary>
        [EnumMember(Value = "location")]
        Location = 1 << 5,
        /// <summary>
        /// 图文消息
        /// </summary>
        [EnumMember(Value = "news")]
        News = 1 << 6,
        /// <summary>
        /// 文件消息
        /// </summary>
        [EnumMember(Value = "file")]
        File = 1 << 7,
        /// <summary>
        /// mpnews消息
        /// </summary>
        [EnumMember(Value = "mpnews")]
        MpNews = 1 << 8
    }
}

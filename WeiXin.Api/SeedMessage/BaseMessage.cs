using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Qhyhgf.WeiXin.Qy.Api.Domain;

namespace Qhyhgf.WeiXin.Qy.Api.SeedMessage
{
    /// <summary>
    /// 主动发送消息基类
    /// </summary>
    [Serializable]
    [DataContract]
    public class BaseMessage
    {
        /// <summary>
        /// UserID列表（消息接收者，多个接收者用‘|’分隔）。特殊情况：指定为@all，则向关注该企业应用的全部成员发送
        /// </summary>
        [DataMember(Name = "touser", IsRequired = true)]
        public string ToUser { get; set; }
        /// <summary>
        /// PartyID列表，多个接受者用‘|’分隔。当touser为@all时忽略本参数
        /// </summary>
        [DataMember(Name = "toparty", IsRequired = true)]
        public string ToParty { get; set; }
        /// <summary>
        /// TagID列表，多个接受者用‘|’分隔。当touser为@all时忽略本参数
        /// </summary>
        [DataMember(Name = "totag", IsRequired = true)]
        public string ToTag { get; set; }
        /// <summary>
        /// 消息类型
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        [DataMember(Name = "msgtype", IsRequired = true)]
        public MessageType MsgType { get; set; }
        /// <summary>
        /// 企业应用的id，整型。可在应用的设置页面查看
        /// </summary>
         [DataMember(Name = "agentid", IsRequired = true)]
        public string AgentId { get; set; }
    }
}

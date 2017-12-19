using Newtonsoft.Json;
using Qhyhgf.WeiXin.Qy.Api.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    /// <summary>
    /// 打卡基本信息
    /// </summary>
    [Serializable]
    [DataContract]
    public class CheckInDataEntity
    {
        /// <summary>
        /// 用户id
        /// </summary>
        [DataMember(Name = "userid")]
        public string UserId { get; set; }
        /// <summary>
        /// 打卡规则名称
        /// </summary>
        [DataMember(Name = "groupname")]
        public string GroupName { get; set; }
        /// <summary>
        /// 打卡类型
        /// </summary>
        [DataMember(Name = "checkin_type")]
        public string CheckInType { get; set; }
        /// <summary>
        /// 打卡类型
        /// </summary>
        [DataMember(Name = "exception_type")]
        public string ExceptionType { get; set; }
        /// <summary>
        /// 打卡时间。UTC时间戳
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [DataMember(Name = "checkin_time")]
        public DateTime CheckInTime { get; set; }
        /// <summary>
        /// 打卡地点title
        /// </summary>
        [DataMember(Name = "location_title")]
        public string LocationTitle { get; set; }
        /// <summary>
        /// 打卡地点详情
        /// </summary>
        [DataMember(Name = "location_detail")]
        public string LocationDetail { get; set; }
        /// <summary>
        /// 打卡wifi名称
        /// </summary>
        [DataMember(Name = "wifiname")]
        public string WifiName { get; set; }
        /// <summary>
        /// 打卡备注
        /// </summary>
        [DataMember(Name = "notes")]
        public string Notes { get; set; }
        /// <summary>
        /// 打卡的MAC地址/bssid
        /// </summary>
        [DataMember(Name = "wifimac")]
        public string WifiMac { get; set; }
        /// <summary>
        ///打卡的附件media_id，可使用media/get获取附件
        /// </summary>
        [DataMember(Name = "mediaids", IsRequired = false)]
        public List<string> MediaIds { get; set; }
    }
}

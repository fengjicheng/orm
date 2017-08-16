using Newtonsoft.Json;
using Qhyhgf.WeiXin.Qy.Api.Attribute;
using Qhyhgf.WeiXin.Qy.Api.Helpers;
using Qhyhgf.WeiXin.Qy.Api.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Qhyhgf.WeiXin.Qy.Api.Request
{
    /// <summary>
    /// 获取打卡数据
    /// </summary>
    [Serializable]
    [DataContract]
    [HttpMethod(Method = HttpVerb.Post, Url = "https://qyapi.weixin.qq.com/cgi-bin/checkin/getcheckindata", Name = "获取打卡数据", IsToken = true, Serialize = SerializeVerb.Json)]
    public class GetCheckInDataRequest : IWeiXinRequest<GetCheckInDataResponse>
    {
        /// <summary>
        /// 打卡类型。1：上下班打卡；2：外出打卡；3：全部打卡
        /// </summary>
        [DataMember(Name = "opencheckindatatype", IsRequired = true)]
        public int OpenCheckInDataType { get; set; }
        /// <summary>
        /// 获取打卡记录的开始时间。UTC时间戳
        /// 获取记录时间跨度不超过三个月
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [DataMember(Name = "starttime", IsRequired = true)]
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 获取打卡记录的结束时间。UTC时间戳
        /// 获取记录时间跨度不超过三个月
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [DataMember(Name = "endtime", IsRequired = true)]
        public DateTime EndTime { get; set; }
        /// <summary>
        ///需要获取打卡记录的用户列表
        ///用户列表不超过100个。若用户超过100个
        /// </summary>
        [DataMember(Name = "useridlist", IsRequired = true)]
        public IList<string> UserIdList { get; set; }
    }
}

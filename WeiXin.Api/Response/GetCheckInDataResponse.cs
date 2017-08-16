using Qhyhgf.WeiXin.Qy.Api.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    /// <summary>
    /// 打卡记录
    /// </summary>
    public class GetCheckInDataResponse : WeiXinResponse
    {
        /// <summary>
        /// 获取的list列表
        /// </summary>
        [DataMember(Name = "checkindata", IsRequired = false)]
        public IList<CheckInDataEntity> ResultContent { get; set; }
    }
}

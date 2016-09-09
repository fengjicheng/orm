using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Attribute;
using Qhyhgf.WeiXin.Qy.Api.Response;

namespace Qhyhgf.WeiXin.Qy.Api.Request
{
    /// <summary>
    /// 设置企业号应用
    /// </summary>
    [Serializable]
    [DataContract]
    [HttpMethod(Method = HttpVerb.Post, Url = "https://qyapi.weixin.qq.com/cgi-bin/agent/set", Name = "设置企业号pu应用", IsToken = true, Serialize = SerializeVerb.Json)]
    public class SetAgentRequest : IWeiXinRequest<SetAgentResponse>
    {
        /// <summary>
        /// 企业应用的id
        /// </summary>
        [DataMember(Name = "agentid", IsRequired = true)]
        public string AgentId { get; set; }
        /// <summary>
        /// 企业应用是否打开地理位置上报 0：不上报；1：进入会话上报；2：持续上报
        /// </summary>
        [DataMember(Name = "report_location_flag")]
        public string ReportLocationFlag { get; set; }
        /// <summary>
        /// 企业应用头像的mediaid，通过多媒体接口上传图片获得mediaid，上传后会自动裁剪成方形和圆形两个头像
        /// </summary>
        [DataMember(Name = "logo_mediaid")]
        public string LogoMediaid { get; set; }
        /// <summary>
        /// 企业应用名称
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }
        /// <summary>
        /// 企业应用详情
        /// </summary>
        [DataMember(Name = "description")]
        public string Description { get; set; }
        /// <summary>
        /// 企业应用可信域名
        /// </summary>
        [DataMember(Name = "redirect_domain")]
        public string RedirectDomain { get; set; }
        /// <summary>
        /// 是否接收用户变更通知。0：不接收；1：接收
        /// </summary>
        [DataMember(Name = "isreportuser")]
        public int isreportuser { get; set; }
        /// <summary>
        /// 是否上报用户进入应用事件。0：不接收；1：接收
        /// </summary>
        [DataMember(Name = "isreportenter")]
        public int isreportenter { get; set; }
    }
}

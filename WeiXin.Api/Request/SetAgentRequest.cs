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
        public int Isreportuser { get; set; }
        /// <summary>
        /// 是否上报用户进入应用事件。0：不接收；1：接收
        /// </summary>
        [DataMember(Name = "isreportenter")]
        public int Isreportenter { get; set; }
        /// <summary>
        /// 主页型应用url。url必须以http或者https开头。消息型应用无需该参数
        /// </summary>
        [DataMember(Name = "home_url")]
        public int HomeUrl { get; set; }
        /// <summary>
        /// 关联会话url。设置该字段后，企业会话"+"号将出现该应用，点击应用可直接跳转到此url，支持jsapi向当前会话发送消息。
        /// </summary>
        [DataMember(Name = "chat_extension_url")]
        public int ChatExtensionUrl { get; set; }
    }
}

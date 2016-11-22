using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    /// <summary>
    /// Agent基本信息
    /// </summary>
    [Serializable]
    [DataContract]
    public class AgentEntity
    {
        /// <summary>
        /// 应用id
        /// </summary>
        [DataMember(Name = "agentid")]
        public string Agentid { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }
        /// <summary>
        ///方形头像url
        /// </summary>
        [DataMember(Name = "square_logo_url")]
        public string SquareLogoUrl { get; set; }
        /// <summary>
        ///圆形头像url
        /// </summary>
        [DataMember(Name = "round_logo_url")]
        public string RoundLogoUrl { get; set; }
    }
}

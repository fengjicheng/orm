using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Qhyhgf.WeiXin.Qy.Api.SeedMessage;

namespace Qhyhgf.WeiXin.Qy.SeedMessage
{
    [Serializable]
    [DataContract]
    public class MpNewsList
    {
        public MpNewsList()
        {
            MpNewsContent = new List<MpNewsEntity>();
        }
        /// <summary>
        /// 图文消息，一个图文消息支持1到10个图文
        /// </summary>
        [DataMember(Name = "articles", IsRequired = true)]
        public IList<MpNewsEntity> MpNewsContent { get; set; }
    }
}

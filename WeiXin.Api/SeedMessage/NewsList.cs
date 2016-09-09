using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.SeedMessage
{
    [Serializable]
    [DataContract]
    public class NewsList
    {
        public NewsList()
        {
            NewsContent = new List<NewsEntity>();
        }
        /// <summary>
        /// 图文消息，一个图文消息支持1到10条图文
        /// </summary>
        [DataMember(Name = "articles", IsRequired = true)]
        public IList<NewsEntity> NewsContent { get; set; }
    }
}

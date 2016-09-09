using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.SeedMessage
{

    [Serializable]
    [DataContract]
    public class NewsEntity
    {
        /// <summary>
        /// 标题
        /// </summary>
        [DataMember(Name = "title")]
        public string Title { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [DataMember(Name = "description")]
        public string Description { get; set; }
        /// <summary>
        /// 点击后跳转的链接。企业可根据url里面带的code参数校验员工的真实身份。具体参考“9 微信页面跳转员工身份查询”
        /// </summary>
        [DataMember(Name = "url")]
        public string Url { get; set; }
        /// <summary>
        /// 图文消息的图片链接，支持JPG、PNG格式，较好的效果为大图640*320，小图80*80。如不填，在客户端不显示图片
        /// </summary>
        [DataMember(Name = "picurl")]
        public string PicUrl { get; set; }

    }
}

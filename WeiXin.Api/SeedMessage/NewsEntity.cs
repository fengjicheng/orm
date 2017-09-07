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
        /// 标题，不超过128个字节，超过会自动截断
        /// </summary>
        [DataMember(Name = "title",IsRequired =true)]
        public string Title { get; set; }
        /// <summary>
        ///描述，不超过512个字节，超过会自动截断
        /// </summary>
        [DataMember(Name = "description")]
        public string Description { get; set; }
        /// <summary>
        /// 点击后跳转的链接。企业可根据url里面带的code参数校验员工的真实身份。具体参考“9 微信页面跳转员工身份查询”
        /// </summary>
        [DataMember(Name = "url",IsRequired =true)]
        public string Url { get; set; }
        /// <summary>
        /// 图文消息的图片链接，支持JPG、PNG格式，较好的效果为大图640320，小图8080。
        /// </summary>
        [DataMember(Name = "picurl")]
        public string PicUrl { get; set; }
        /// <summary>
        /// 按钮文字，仅在图文数为1条时才生效。 默认为“阅读全文”， 不超过4个文字，超过自动截断。该设置只在企业微信上生效，微信插件上不生效。
        /// </summary>
        [DataMember(Name = "picurl")]
        public string Btntxt { get; set; }

    }
}

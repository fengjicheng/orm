using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.SeedMessage
{
    [Serializable]
    [DataContract]
    public class TextCardEntity
    {
        /// <summary>
        /// 标题，不超过128个字节，超过会自动截断
        /// </summary>
        [DataMember(Name = "title", IsRequired = true)]
        public string Title { get; set; }

        /// <summary>
        /// 描述，不超过512个字节，超过会自动截断
        /// 卡片消息的展现形式非常灵活，支持使用br标签或者空格来进行换行处理，也支持使用div标签来使用不同的字体颜色，目前内置了3种文字颜色：灰色(gray)、高亮(highlight)、默认黑色(normal)，将其作为div标签的class属性即可，具体用法请参考上面的示例。
        /// </summary>
        [DataMember(Name = "description", IsRequired = true)]
        public string Description { get; set; }
        /// <summary>
        /// 点击后跳转的链接。
        /// </summary>
        [DataMember(Name = "url", IsRequired = true)]
        public string Url { get; set; }
        /// <summary>
        /// 按钮文字。 默认为“详情”， 不超过4个文字，超过自动截断。
        /// </summary>
        [DataMember(Name = "btntxt", IsRequired = false)]
        public string Btntxt { get; set; }
    }
}

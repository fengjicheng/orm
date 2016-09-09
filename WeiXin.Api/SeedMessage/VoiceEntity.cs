using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.SeedMessage
{
    [Serializable]
    [DataContract]
    public  class VoiceEntity
    {
        /// <summary>
        /// 视频媒体文件id，可以调用上传媒体文件接口获取
        /// </summary>
        [DataMember(Name = "media_id", IsRequired = true)]
        public string MediaId { get; set; }
    }
}

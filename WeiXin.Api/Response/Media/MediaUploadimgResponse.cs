using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Qhyhgf.WeiXin.Qy.Api.Domain;

namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    /// <summary>
    /// 上传图片
    /// </summary>
    public class MediaUploadimgResponse: WeiXinResponse
    {
        /// <summary>
        /// 上传后得到的图片URL。永久有效
        /// </summary>
        [DataMember(Name = "url")]
         public string Url { get; set; }
    }
}

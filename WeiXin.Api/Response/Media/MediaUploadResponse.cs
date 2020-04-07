using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Qhyhgf.WeiXin.Qy.Api.Domain;
/*
                           _ooOoo_
                          o8888888o
                          88" . "88
                          (| -_- |)
                          O\  =  /O
                       ____/`---'\____
                     .'  \\|     |//  `.
                    /  \\|||  :  |||//  \
                   /  _||||| -:- |||||-  \
                   |   | \\\  -  /// |   |
                   | \_|  ''\---/''  |   |
                   \  .-\__  `-`  ___/-. /
                 ___`. .'  /--.--\  `. . __
              ."" '<  `.___\_<|>_/___.'  >'"".
             | | :  `- \`.;`\ _ /`;.`/ - ` : | |
             \  \ `-.   \_ __\ /__ _/   .-` /  /
        ======`-.____`-.___\_____/___.-`____.-'======
                           `=---='
        ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
                 佛祖保佑       永无BUG
        *********************************************
        * 作者：冯际成
        * 单位：青海盐湖工业股份有限公司信息中心
        * 电话：15209793953
 */
namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    /// <summary>
    /// 上传多媒体
    /// </summary>
    public class MediaUploadResponse:WeiXinResponse
    {
        /// <summary>
        /// 媒体文件类型，分别有图片（image）、语音（voice）、视频（video）,普通文件(file)
        /// </summary>
       /// [JsonIgnore]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        [DataMember(Name = "type")]
        public MediaType Type { get; set; }
        /// <summary>
        /// 媒体文件上传后获取的唯一标识
        /// </summary>
         [DataMember(Name = "media_id")]
        public string MediaId { get; set; }
        /// <summary>
         /// 媒体文件上传时间戳
        /// </summary>
        [DataMember(Name = "created_at")]
         public long CreatedAt { get; set; }
    }
}

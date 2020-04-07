using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Qhyhgf.WeiXin.Qy.Api.Attribute;
using Qhyhgf.WeiXin.Qy.Api.Response;
using Qhyhgf.WeiXin.Qy.Api.Domain;
using System.Runtime.Serialization;
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
namespace Qhyhgf.WeiXin.Qy.Api.Request
{

    /// <summary>
    /// 上传图片
    /// 上传图片得到图片URL，该URL永久有效
    /// 返回的图片URL，仅能用于图文消息（mpnews）正文中的图片展示；若用于非企业微信域名下的页面，图片将被屏蔽。
    /// 每个企业每天最多可上传100张图片
    /// </summary>
    [HttpMethod(Method = HttpVerb.File, Url = "https://qyapi.weixin.qq.com/cgi-bin/media/upload", Name = "上传图片", IsToken = true, Serialize = SerializeVerb.Json)]
    public class MediaUploadimgRequest : IWeiXinRequest<MediaUploadimgResponse>
    {
        public MediaUploadimgRequest() {
            Type = MediaType.Image;
        }
        /// <summary>
        /// 媒体文件类型，分别有图片（image）、语音（voice）、视频（video），普通文件(file)
        /// </summary>
        [DataMember(Name = "type", IsRequired = false)]
        public MediaType Type { get; set; }
        /// <summary>
        /// 多媒体路径
        /// </summary>
        [DataMember(IsRequired = true, Name = "media")]
        public string Media { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Helpers;
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
namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    /// <summary>
    /// 被动响应text消息
    /// </summary>
    [Serializable]
    [XmlRoot("xml")]
    public class RequestNews : BaseMessage
    {
        public RequestNews()
        {
            //消息类型
            MsgType = new CDATA<MessageType>(MessageType.News);
            //消息发送时间
            CreateTime = DateTime.Now.ConvertToTimeStamp();
            PicContent = new List<PicEntity>();
        }
        /// <summary>
        /// 图文条数，默认第一条为大图。图文数不能超过10，否则将会无响应
        /// </summary>
        [XmlElement("ArticleCount")]
        public int ArticleCount { get; set; }
        /// <summary>
        /// 文本消息内容
        /// </summary>
        [XmlArray("Articles")]
        [XmlArrayItem("item")]
        public List<PicEntity> PicContent { get; set; }
    }
}

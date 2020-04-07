using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
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
    /// 发送的图片信息
    /// </summary>
    [Serializable]
    [XmlRoot("xml")]
    public class SendPicsInfoEntity
    {
        [XmlElement("EventKey")]
        public int Count { get; set; }
        /// <summary>
        /// 图片列表
        /// </summary>
       // [XmlElement("PicList")]
        [XmlArray("PicList")]
        [XmlArrayItem("item")]
        public List<PicItemEntity> PicList { get; set; }
    }
}

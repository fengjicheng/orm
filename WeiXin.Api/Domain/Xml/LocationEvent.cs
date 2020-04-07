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
    /// 上报地理位置事件
    /// </summary>
    [Serializable]
    [XmlRoot("xml")]
    public class LocationEvent : BaseMessage
    {
        /// <summary>
        /// 地理位置纬度
        /// </summary>
        [XmlElement("Latitude")]
        public string Latitude { set; get; }
        /// <summary>
        /// 地理位置经度
        /// </summary>
        [XmlElement("Longitude")]
        public string Longitude { set; get; }
        /// <summary>
        ///地理位置精度
        /// </summary>
        [XmlElement("Precision")]
        public string Precision { set; get; }
    }
}

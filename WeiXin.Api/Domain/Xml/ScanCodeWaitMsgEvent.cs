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
    /// 扫码推事件且弹出“消息接收中”提示框的事件推送
    /// </summary>
    [Serializable]
    [XmlRoot("xml")]
    public class ScanCodeWaitMsgEvent : BaseEvent
    {
        /// <summary>
        /// 事件KEY值，由开发者在创建菜单时设定
        /// </summary>
        [XmlElement("EventKey")]
        public CDATA<string> EventKey { get; set; }
        /// <summary>
        /// 扫描信息
        /// </summary>
        [XmlElement("ScanCodeInfo")]
        public ScanCodeInfoEntity Entity { get; set; }
    }
}

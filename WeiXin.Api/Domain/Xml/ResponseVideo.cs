﻿using System;
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
    /// Video消息
    /// </summary>
    [Serializable]
    [XmlRoot("xml")]
    public class ResponseVideo : BaseMessage
    {
        /// <summary>
        /// 消息id，64位整型
        /// </summary>
        [XmlElement("MediaId")]
        public CDATA<string> MediaId { get; set; }
        /// <summary>
        /// 视频消息缩略图的媒体id，可以调用获取媒体文件接口拉取数据
        /// </summary>
        [XmlElement("ThumbMediaId")]
        public CDATA<string> ThumbMediaId { get; set; }
        /// <summary>
        /// 消息id，64位整型
        /// </summary>
        [XmlElement("MsgId")]
        public long MsgId { get; set; }
        /// <summary>
        /// 企业应用的id，整型。可在应用的设置页面查看
        /// </summary>
        [XmlElement("AgentID")]
        public int AgentID { get; set; }
    }
}

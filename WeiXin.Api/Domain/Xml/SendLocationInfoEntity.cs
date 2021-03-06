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
    [Serializable]
    public class SendLocationInfoEntity
    {
        /// <summary>
        /// X坐标信息
        /// </summary>
        [XmlElement("Location_X")]
        public CDATA<string> LocationX { get; set; }
        /// <summary>
        /// Y坐标信息
        /// </summary>
        [XmlElement("Location_Y")]
        public CDATA<string> LocationY { get; set; }
        /// <summary>
        /// 精度，可理解为精度或者比例尺、越精细的话 scale越高
        /// </summary>
        [XmlElement("Scale")]
        public CDATA<string> Scale { get; set; }
        /// <summary>
        /// 地理位置的字符串信息
        /// </summary>
        [XmlElement("Label")]
        public CDATA<string> Label { get; set; }
        [XmlElement("Poiname")]
        public CDATA<string> Poiname { get; set; }
    }
}

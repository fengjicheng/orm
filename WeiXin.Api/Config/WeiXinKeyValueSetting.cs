using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
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
namespace Qhyhgf.WeiXin.Qy.Api.Config
{
    public class WeiXinKeyValueSetting : ConfigurationElement	// 集合中的每个元素
    {
        /// <summary>
        /// 企业应用的id，整型
        /// </summary>
        [ConfigurationProperty("AgentID", IsRequired = true)]
        public string AgentID
        {
            get { return this["AgentID"].ToString(); }
            set { this["AgentID"] = value; }
        }
        /// <summary>
        /// Token值
        /// </summary>
        [ConfigurationProperty("Token", IsRequired = true)]
        public string Token
        {
            get { return this["Token"].ToString(); }
            set { this["Token"] = value; }
        }
        /// <summary>
        /// EncodingAESKey值
        /// </summary>
        [ConfigurationProperty("EncodingAESKey", IsRequired = true)]
        public string EncodingAESKey
        {
            get { return this["EncodingAESKey"].ToString(); }
            set { this["EncodingAESKey"] = value; }
        }
        /// <summary>
        /// Secret值
        /// </summary>
        [ConfigurationProperty("Secret", IsRequired = true)]
        public string Secret
        {
            get { return this["Secret"].ToString(); }
            set { this["Secret"] = value; }
        }
        /// <summary>
        /// 名称
        /// </summary>
        [ConfigurationProperty("Name", IsRequired = true)]
        public string Name
        {
            get { return this["Name"].ToString(); }
            set { this["Name"] = value; }
        }
    }
}

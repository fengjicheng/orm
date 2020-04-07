using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using Qhyhgf.WeiXin.Qy.Api.Token;
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
    public class WeiXinSection : ConfigurationSection
    {
        private static WeiXinSection instance;
        private static object _lock = new object();
        /// <summary>
        /// 屏蔽掉无参数构造函数
        /// </summary>
        private WeiXinSection()
        {
        
        }
        public static WeiXinSection GetInstance()
        {
            if (instance == null)
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = (WeiXinSection)ConfigurationManager.GetSection("WeiXinSection");
                    }
 
                }
                
            }
            return instance;
        }
        //用于集合
        private static readonly ConfigurationProperty s_property
            = new ConfigurationProperty(string.Empty, typeof(WeiXinCollection), null,
                                            ConfigurationPropertyOptions.IsDefaultCollection);
        /// <summary>
        /// secret CorpID集合信息。
        /// </summary>
        [ConfigurationProperty("", Options = ConfigurationPropertyOptions.IsDefaultCollection)]
        public WeiXinCollection KeyValues
        {
            get
            {
                return (WeiXinCollection)base[s_property];
            }
        }
        /// <summary>
        /// CorpID值
        /// </summary>
        [ConfigurationProperty("CorpID", IsRequired = true)]
        public string CorpID
        {
            get { return this["CorpID"].ToString(); }
            set { this["CorpID"] = value; }
        }
        /// <summary>
        /// 缓存类型
        /// </summary>
        [ConfigurationProperty("CacheType", IsRequired = true)]
        public string CacheType {
            get { return this["CacheType"].ToString(); }
            set { this["CacheType"] = value; }
        }
    }
}

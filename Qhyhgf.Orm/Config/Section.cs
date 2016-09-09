/*----------------------------------------------------------------
 * 作者：冯际成
 * 时间：2015年1月15日
 * ----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Qhyhgf.Orm.Config
{
    /// <summary>
    /// web.config节点定义
    /// </summary>
    internal class Section : ConfigurationSection
    {
        private static Section instance;
        private static object _lock = new object();
        /// <summary>
        /// 屏蔽掉无参数构造函数
        /// </summary>
        private Section()
        {
        
        }
        public static Section GetInstance()
        {
            if (instance == null)
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = (Section)ConfigurationManager.GetSection("Orm");
                    }
 
                }
                
            }
            return instance;
        }
        //用于集合
        private static readonly ConfigurationProperty s_property
            = new ConfigurationProperty(string.Empty, typeof(Collection), null,
                                            ConfigurationPropertyOptions.IsDefaultCollection);
        /// <summary>
        /// ORM集合信息。
        /// </summary>
        [ConfigurationProperty("", Options = ConfigurationPropertyOptions.IsDefaultCollection)]
        public Collection KeyValues
        {
            get
            {
                return (Collection)base[s_property];
            }
        }
        /// <summary>
        /// 是否加密(默认不加密)
        /// </summary>
        [ConfigurationProperty("IsEncrypt", IsRequired = true)]
        public bool IsEncrypt
        {
            get
            {
                try
                {
                    string sIsEncrypt = this["IsEncrypt"].ToString();
                    if (string.IsNullOrEmpty(sIsEncrypt))
                    {
                        return false;
                    }
                    return Convert.ToBoolean(sIsEncrypt);
                }
                catch (NullReferenceException ex)
                {
                    throw ex;
                }       
            }
            set { this["IsEncrypt"] = value; }
        }
        /// <summary>
        /// AESKey加密值
        /// </summary>
        [ConfigurationProperty("AESKey", IsRequired = false)]
        public string AESKey
        {
            get { return this["AESKey"].ToString(); }
            set { this["AESKey"] = value; }
        }
    }
}

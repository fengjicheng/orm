using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using Qhyhgf.WeiXin.Qy.Api.TokenFachory;

namespace Qhyhgf.WeiXin.Qy.Api.Config
{
    internal class WeiXinSection : ConfigurationSection
    {
        private static WeiXinSection instance;
        private static object _lock = new object();
        /// <summary>
        /// 屏蔽掉无参数构造函数
        /// </summary>
        private WeiXinSection()
        {
        
        }
        /// <summary>
        /// 把config读取到的内容转化到Token
        /// </summary>
        /// <returns></returns>
        public TokenCollection ToTokenCollection()
        {
            TokenCollection collection = new TokenCollection();
            foreach (var item in KeyValues)
            {
                TokenEntity tokenItem = new TokenEntity();
                if (item is WeiXinKeyValueSetting)
                {
                    lock (_lock)
                    {
                        WeiXinKeyValueSetting value = item as WeiXinKeyValueSetting;
                        tokenItem.CorpID = CorpID;
                        tokenItem.EndRequest = DateTime.Now.AddSeconds(-int.MaxValue);
                        tokenItem.AgentID = value.AgentID;
                        tokenItem.Name = value.Name;
                        tokenItem.Secret = value.Secret;
                        tokenItem.AccessToken = string.Empty;
                        tokenItem.Token = Token;
                        tokenItem.EncodingAESKey = EncodingAESKey;
                        collection.Add(tokenItem);
                    }
                }
            }
            return collection;
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
        /// CorpID值
        /// </summary>
        [ConfigurationProperty("CorpID", IsRequired = true)]
        public string CorpID
        {
            get { return this["CorpID"].ToString(); }
            set { this["CorpID"] = value; }
        }
    }
}

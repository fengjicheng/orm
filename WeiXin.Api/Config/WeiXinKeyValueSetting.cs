using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Qhyhgf.WeiXin.Qy.Api.Config
{
    internal class WeiXinKeyValueSetting : ConfigurationElement	// 集合中的每个元素
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

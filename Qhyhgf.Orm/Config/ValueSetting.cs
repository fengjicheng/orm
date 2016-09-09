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
    internal class KeyValueSetting : ConfigurationElement	// 集合中的每个元素
    {
        /// <summary>
        /// GUID数据库连接唯一标识
        /// </summary>
        [ConfigurationProperty("Gid", IsRequired = true)]
        public string Gid
        {
            get { return this["Gid"].ToString(); }
            set { this["Gid"] = value; }
        }

        /// <summary>
        /// 数据库连接描述（可为空）
        /// </summary>
        [ConfigurationProperty("Description", IsRequired = false)]
        public string Description
        {
            get {
                return this["Description"].ToString();
            }
            set { this["Description"] = value; }
        }
        /// <summary>
        /// 连接字符串
        /// </summary>
        [ConfigurationProperty("Conn", IsRequired = true)]
        public string Conn
        {
            get { return this["Conn"].ToString(); }
            set { this["Conn"] = value; }
        }
        /// <summary>
        /// 针对数据库操作的动作
        /// </summary>
        [ConfigurationProperty("Action", IsRequired = true)]
        public ActionType Action
        {
            get
            {
                return (ActionType)Enum.Parse(typeof(ActionType), this["Action"].ToString(), false);
            }
            set
            {
                this["Action"] = Enum.GetName(typeof(ActionType), value);
            }
        }
        /// <summary>
        /// 数据库类型
        /// </summary>
        [ConfigurationProperty("DataType", IsRequired = true)]
        public DataSourceType DataType
        {
            get
            {
                return (DataSourceType)Enum.Parse(typeof(DataSourceType), this["DataType"].ToString(), false);
            }
            set
            {
                this["DataType"] = Enum.GetName(typeof(DataSourceType), value);
            }
        }
        /// <summary>
        /// 命中率
        /// </summary>
        [ConfigurationProperty("Accuracy", IsRequired = true)]
        public int Accuracy
        {
            get
            {
                int outInt;
                if (int.TryParse(this["Accuracy"].ToString(), out outInt))
                {
                    if (1>outInt || outInt>256 )
                    {
                         throw new ArgumentNullException("配置文件中命中率取值范围为1-255");
                    }
                    return outInt;
                }
                else
                {
                    throw new ArgumentNullException("配置文件中DataType错误");
                }
            }
            set
            {
                this["Accuracy"] = value;
            }
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
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
    /// 扩展属性
    /// </summary>
    [Serializable]
    [DataContract]
    public  class AttrsEntity
    {
        /// <summary>
        /// 属性名
        /// </summary>
        [DataMember(Name = "name",IsRequired=true)]
        public string Name { get; set; }
        /// <summary>
        /// 属性值
        /// </summary>
        [DataMember(Name = "value",IsRequired=true)]
        public string Value { get; set; }
    }
    /// <summary>
    /// 扩展属性添加方法
    /// </summary>
    [Serializable]
    [DataContract]
    public class Attrs {
      [DataMember(Name = "attrs", IsRequired = true)]
       public IList<AttrsEntity> AttrsContent { get; set; }
    }
}

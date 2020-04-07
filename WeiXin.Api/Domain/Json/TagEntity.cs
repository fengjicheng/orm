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
    /// 标签基本信息
    /// </summary>
    [Serializable]
    [DataContract]
    public class TagEntity
    {
        /// <summary>
        /// 标签ID
        /// </summary>
        [DataMember(Name = "tagid")]
        public int TagId { get; set; }
        /// <summary>
        /// 标签名称
        /// </summary>
        [DataMember(Name = "tagname")]
        public string tagname { get; set; }
    }
    /// <summary>
    /// 标签组
    /// </summary>
    public class Tags
    {
        /// <summary>
        /// 标签列表列表
        /// </summary>
        [DataMember(Name = "taglist", IsRequired = false)]
        public IList<TagEntity> TagContent { get; set; }
    }
}

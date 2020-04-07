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
    /// 部门项信息
    /// </summary>
    [Serializable]
    [DataContract]
    public class DepartmentEntity
    {
        /// <summary>
        /// 部门id
        /// </summary>
        [DataMember(Name = "id")]
        public int ID { get; set; }
        /// <summary>
        /// 部门名称
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }
        /// <summary>
        /// 父亲部门id。根部门为1
        /// </summary>
        [DataMember(Name = "parentid")]
        public int ParentId { get; set; }
        /// <summary>
        /// 在父部门中的次序值。order值小的排序靠前。
        /// </summary>
        [DataMember(Name = "order")]
        public int Order { get; set; }
    }
}

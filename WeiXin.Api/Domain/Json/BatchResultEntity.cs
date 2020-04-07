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
    /// 异步查询结果具体值
    /// </summary>
    [Serializable]
    [DataContract]
    public class BatchResultEntity
    {
        /// <summary>
        /// 对应操作的结果错误码
        /// </summary>
        [DataMember(Name = "errcode", IsRequired = false)]
        public long ErrCode { get; set; }
        /// <summary>
        /// 错误信息，例如无权限错误，键值冲突，格式错误等
        /// </summary>
        [DataMember(Name = "errmsg", IsRequired = false)]
        public string ErrMsg { get; set; }
        /// <summary>
        /// 成员UserID。对应管理端的帐号
        /// </summary>
        [DataMember(Name = "userid", IsRequired = false)]
        public string UserId { get; set; }
        /// <summary>
        /// 操作类型（按位或）：1 新建部门 ，2 更改部门名称， 4 移动部门， 8 修改部门排序
        /// </summary>
        [DataMember(Name = "action", IsRequired = false)]
        public int Action { get; set; }
        /// <summary>
        /// 部门ID
        /// </summary>
        [DataMember(Name = "partyid", IsRequired = false)]
        public int PartyId { get; set; }
    }
}

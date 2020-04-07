using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Attribute;
using Qhyhgf.WeiXin.Qy.Api.Response;
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
namespace Qhyhgf.WeiXin.Qy.Api.Request
{
    /// <summary>
    /// 增加标签成员
    /// </summary>
    [Serializable]
    [DataContract]
    [HttpMethod(Method = HttpVerb.Post, Url = "https://qyapi.weixin.qq.com/cgi-bin/tag/addtagusers", Name = "增加标签成员", IsToken = true, Serialize = SerializeVerb.Json)]
    public class AddTagusersTagRequest : IWeiXinRequest<AddTagusersTagResponse>
    {
        /// <summary>
        /// 标签ID
        /// </summary>
        [DataMember(Name = "tagid", IsRequired = true)]
        public string TagId { get; set; }
        /// <summary>
        /// 企业员工ID列表，注意：userlist、partylist不能同时为空
        /// </summary>
        [DataMember(Name = "userlist")]
        public IList<string> UserList { get; set; }
        /// <summary>
        /// 企业部门ID列表，注意：userlist、partylist不能同时为空
        /// </summary>
        [DataMember(Name="DataMember")]
        public IList<int> PartyList { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Qhyhgf.WeiXin.Qy.Api.Response;
using Qhyhgf.WeiXin.Qy.Api.Attribute;
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
namespace Qhyhgf.WeiXin.Qy.Api.Request
{
    /// <summary>
    /// 创建部门
    /// </summary>
    [Serializable]
    [DataContract]
    [HttpMethod(Method = HttpVerb.Post,Url = "https://qyapi.weixin.qq.com/cgi-bin/department/create", Name = "创建部门",IsToken= true,Serialize=SerializeVerb.Json)]
    public class CreateDepartmentRequest : IWeiXinRequest<CreateDepartmentResponse>
    {
        /// <summary>
        /// 部门名称。长度限制为1~64个字符
        /// </summary>
        [DataMember(Name = "name", IsRequired = true)]
        public string Name { get; set; }
        /// <summary>
        /// 父亲部门id。根部门id为1
        /// </summary>
        [DataMember(Name = "parentid", IsRequired = true)]
        public int ParentId { get; set; }
        /// <summary>
        /// 在在父部门中的次序值。order值大的排序靠前。有效的值范围是[0, 2^32)
        /// </summary>
        [DataMember(Name = "order", IsRequired = false)]
        public int Order { get; set; }
        /// <summary>
        /// 部门id，整型。指定时必须大于1，否则自动生成
        /// </summary>
        [DataMember(Name = "id", IsRequired = false)]
        public int Id { get; set; }
    }
}

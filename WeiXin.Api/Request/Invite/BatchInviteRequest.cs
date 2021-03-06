﻿using System;
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
    /// 邀请成员
    /// </summary>
    [Serializable]
    [DataContract]
    [HttpMethod(Method = HttpVerb.Post,Url = "https://qyapi.weixin.qq.com/cgi-bin/batch/invite", Name = "邀请成员", IsToken= true,Serialize=SerializeVerb.Json)]
    public class BatchInviteRequest : IWeiXinRequest<BatchInviteResponse>
    {
        /// <summary>
        /// 成员ID列表, 最多支持1000个。
        /// </summary>
        [DataMember(Name = "user", IsRequired = false)]
        public IList<string> User { get; set; }
        /// <summary>
        /// 部门ID列表，最多支持100个。
        /// </summary>
        [DataMember(Name = "party", IsRequired = false)]
        public IList<int> Party { get; set; }
        /// <summary>
        /// 标签ID列表，最多支持100个。
        /// </summary>
        [DataMember(Name = "tag", IsRequired = false)]
        public IList<int> Tag { get; set; }
    }
}

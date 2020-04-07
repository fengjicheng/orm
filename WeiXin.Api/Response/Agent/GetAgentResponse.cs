using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Domain;
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
namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    /// <summary>
    /// 获取企业号应用
    /// </summary>
    public class GetAgentResponse : WeiXinResponse
    {
        /// <summary>
        /// 企业应用id
        /// </summary>
        [DataMember(Name = "agentid")]
        public string AgentId { get; set; }
        /// <summary>
        /// 企业应用名称
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }
        /// <summary>
        /// 企业应用方形头像
        /// </summary>
        [DataMember(Name = "square_logo_url")]
        public string SquareLogoUrl { get; set; }
        /// <summary>
        /// 企业应用详情
        /// </summary>
        [DataMember(Name = "description")]
        public string Description { get; set; }
        /// <summary>
        /// 企业应用可见范围（人员），其中包括userid和关注状态state
        /// </summary>
        [DataMember(Name = "allow_userinfos")]
        public AllowUserinfosEntity AllowUserinfos { get; set; }
        /// <summary>
        /// 企业应用可见范围（部门）
        /// </summary>
        [DataMember(Name = "allow_partys")]
        public AllowPartysEntity AllowPartys { get; set; }
        /// <summary>
        /// 企业应用可见范围（标签）
        /// </summary>
        [DataMember(Name = "allow_tags")]
        public AllowTagsEntity AllowTags { get; set; }
        /// <summary>
        /// 企业应用是否被禁用
        /// </summary>
        [DataMember(Name = "close")]
        public int Close { get; set; }
        /// <summary>
        /// 企业应用可信域名
        /// </summary>
        [DataMember(Name = "redirect_domain")]
        public string RedirectDomain { get; set; }
        /// <summary>
        /// 企业应用是否打开地理位置上报 0：不上报；1：进入会话上报；2：持续上报
        /// </summary>
        [DataMember(Name = "report_location_flag")]
        public int ReportLocationFlag { get; set; }
        /// <summary>
        /// 是否上报用户进入应用事件。0：不接收；1：接收
        /// </summary>
        [DataMember(Name = "isreportenter")]
        public int isreportenter { get; set; }
        /// <summary>
        ///应用主页url
        /// </summary>
        [DataMember(Name = "home_url")]
        public string home_url { get; set; }

    }
}

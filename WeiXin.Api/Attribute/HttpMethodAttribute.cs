using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
namespace Qhyhgf.WeiXin.Qy.Api.Attribute
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public sealed class HttpMethodAttribute : System.Attribute
    {
        public HttpMethodAttribute() {
            IsToken = false;
        }
        /// <summary>
        /// 请求类型
        /// </summary>
        public HttpVerb Method { get; set;}
        /// <summary>
        /// 是否需Token验证信息（默认否）
        /// </summary>
        public bool IsToken { get; set; }
        /// <summary>
        /// 接口请求地址
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// Api名字
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Request数据序列化类型
        /// </summary>
        public SerializeVerb Serialize { get; set; }
        /// <summary>
        /// 验证参数
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            return !string.IsNullOrEmpty(Url);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ComponentModel;
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
namespace Qhyhgf.WeiXin.Qy.Api
{
    /// <summary>
    /// 请求基类
    /// </summary>
    [Serializable]
    [DataContract]
    public abstract class WeiXinResponse{
        /// <summary>
        /// 返回码
        /// </summary>
        [DefaultValue(0)]
        [DataMember(Name = "errcode",IsRequired=false)]
        public long ErrCode { get; set; }
        /// <summary>
        /// 对返回码的文本描述内容
        /// </summary>
        [DataMember(Name = "errmsg",IsRequired=false)]
        public string ErrMsg { get; set; }
        public override string ToString()
        {
            return string.Format("请求接口错误，错误代码：{0}，说明：{1}",ErrCode,ErrMsg);
        }

    }
}

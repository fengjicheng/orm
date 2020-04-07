using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Runtime.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Helpers;
using Qhyhgf.WeiXin.Qy.Api.Dynamic;
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
namespace Qhyhgf.WeiXin.Qy.Api.HttpFactory
{

    /// <summary>
    /// Get请求处理
    /// </summary>
    public class HttpGet<T> : Http<T> where T : WeiXinResponse
    {
        /// <summary>
        /// 具体业务实现。
        /// </summary>
        /// <returns></returns>
        public override T GetResponse()
        {
            //判断是否需要身份验证
            if (base.HttpMethodAttribute.IsToken)
            {
                base.HttpMethodAttribute.Url = base.HttpMethodAttribute.Url + WeiXinUtils.BuildGetUrl(base.HttpMethodAttribute.Url
                    ) + "access_token=" + base.Token.AccessToken;
            }
            Type type = base.Request.GetType();
            PropertyInfo[] finfos = type.GetProperties();
            StringBuilder sb = new StringBuilder();
            foreach (PropertyInfo finfo in finfos)
            {
                object val = finfo.FastGetValue(Request);
                string fieldName = finfo.Name;
                string fieldValue = string.Empty;
                object objValue = finfo.FastGetValue(Request);
                if (objValue is Int32 || objValue is string)
                {
                    fieldValue = finfo.FastGetValue(Request).ToString();
                }
                DataMemberAttribute data = (DataMemberAttribute)System.Attribute.GetCustomAttribute(finfo, typeof(DataMemberAttribute));
                if (data != null)
                {
                    //是否是必须参数
                    if (data.IsRequired)
                    {
                        if (string.IsNullOrEmpty(fieldValue))
                        {
                            throw new WeiXinException(string.Format("{0}属性值  不能为空", fieldName));
                        }
                        else
                        {
                            sb.Append(data.Name ?? fieldName);
                            sb.Append("=");
                            sb.Append(fieldValue);
                            sb.Append("&");
                        }
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(fieldValue))
                        {
                            sb.Append(fieldName);
                            sb.Append("=");
                            sb.Append(fieldValue);
                            sb.Append("&");
                        }
                    }
                }
            }
            if (sb.Length>0)
            {
                if (sb.ToString().EndsWith("&"))
                {
                    sb.Remove(sb.Length - 1, 1);
                }
                base.HttpMethodAttribute.Url = base.HttpMethodAttribute.Url + WeiXinUtils.BuildGetUrl(base.HttpMethodAttribute.Url
                      ) + sb.ToString();   
            }
            WebUtils webutils = new WebUtils();
            string strJosn = webutils.DoGet(base.HttpMethodAttribute.Url);
            return strJosn.jsonToObj<T>();
        }
    }
}

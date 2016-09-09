using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Runtime.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Helpers;
using Qhyhgf.WeiXin.Qy.Api.Dynamic;

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
            if (base.HttpMethod.IsToken)
            {
                base.Token.GetAccessToken();
                base.HttpMethod.Url = base.HttpMethod.Url + WeiXinUtils.BuildGetUrl(base.HttpMethod.Url
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
                base.HttpMethod.Url = base.HttpMethod.Url + WeiXinUtils.BuildGetUrl(base.HttpMethod.Url
                      ) + sb.ToString();   
            }
            WebUtils webutils = new WebUtils();
            string strJosn = webutils.DoGet(base.HttpMethod.Url);
            return strJosn.jsonToObj<T>();
        }
    }
}

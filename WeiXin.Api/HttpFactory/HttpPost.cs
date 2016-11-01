using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Runtime.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Helpers;
using Qhyhgf.WeiXin.Qy.Api.Attribute;
using Qhyhgf.WeiXin.Qy.Api.Dynamic;

namespace Qhyhgf.WeiXin.Qy.Api.HttpFactory
{
    /// <summary>
    /// POST请求处理
    /// </summary>
    public class HttpPost<T> : Http<T> where T : WeiXinResponse
    {
        /// <summary>
        /// 具体处理
        /// </summary>
        /// <returns></returns>
        public override T GetResponse()
        {
            string getJosn=string.Empty, rjson=string.Empty;
            WebUtils webutils = new WebUtils();
            //判断是否需要身份验证
            if (base.HttpMethodAttribute.IsToken)
            {
                base.Token.GetAccessToken();
                base.HttpMethodAttribute.Url = base.HttpMethodAttribute.Url + WeiXinUtils.BuildGetUrl(base.HttpMethodAttribute.Url
                    ) + "access_token=" + base.Token.AccessToken;
            }
            //url参数组合
            Type type = base.Request.GetType();
            PropertyInfo[] finfos = type.GetProperties();
            StringBuilder sb = new StringBuilder();
            foreach (PropertyInfo finfo in finfos)
            {
                string fieldName = finfo.Name;
                string fieldValue = string.Empty;
                object objValue = finfo.FastGetValue(Request);
                if (objValue is Int32 || objValue is string)
                {
                    fieldValue = finfo.FastGetValue(Request).ToString();

                    FieldInfo fieldInfo = type.GetField(fieldName);
                    GetParameterAttribute data = (GetParameterAttribute)System.Attribute.GetCustomAttribute(finfo, typeof(GetParameterAttribute));
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
            
            //XML序列化
            if (base.HttpMethodAttribute.Serialize == Attribute.SerializeVerb.Json)
            {
                rjson = Request.objToJson();
                getJosn = webutils.DoPost(base.HttpMethodAttribute.Url, rjson);
                return getJosn.jsonToObj<T>();
            }
            return base.GetResponse();
        }
    }
}

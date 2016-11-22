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
                base.HttpMethodAttribute.Url = base.HttpMethodAttribute.Url + WeiXinUtils.BuildGetUrl(base.HttpMethodAttribute.Url
                    ) + "access_token=" + base.Token.AccessToken;
            }
            //如果手动拼写请求参数
            if (base.HttpMethodAttribute.Serialize == SerializeVerb.None)
            {
                //url参数组合
                Type type = base.Request.GetType();
                PropertyInfo[] finfos = type.GetProperties();
                StringBuilder sb = new StringBuilder();
                foreach (PropertyInfo finfo in finfos)
                {
                    string fieldName = finfo.Name;
                    string fieldValue = string.Empty;
                    object objValue = finfo.FastGetValue(Request);
                    FieldInfo fieldInfo = type.GetField(fieldName);
                    //获得是否为存在get参数
                    GetParameterAttribute getData = (GetParameterAttribute)System.Attribute.GetCustomAttribute(finfo, typeof(GetParameterAttribute));
                    if (getData != null&&(objValue is Int32 || objValue is string))
                    {
                        fieldValue = objValue.ToString();
                        //是否是必须参数
                        if (getData.IsRequired)
                        {
                            if (string.IsNullOrEmpty(fieldValue))
                            {
                                throw new WeiXinException(string.Format("{0}属性值  不能为空", fieldName));
                            }
                            else
                            {
                                sb.Append(getData.Name ?? fieldName);
                                sb.Append("=");
                                sb.Append(fieldValue);
                                sb.Append("&");
                            }
                        }
                        //如果为不必填参数
                        else
                        {
                            //如果得到此值，则拼接上去
                            if (!string.IsNullOrEmpty(fieldValue))
                            {
                                sb.Append(fieldName);
                                sb.Append("=");
                                sb.Append(fieldValue);
                                sb.Append("&");
                            }
                        }
                    }
                    //获得是否为存在get参数
                    PostParameterAttribute postData = (PostParameterAttribute)System.Attribute.GetCustomAttribute(finfo, typeof(PostParameterAttribute));
                    if (postData != null)
                    {
                        if (postData.Serialize== SerializeVerb.Json)
                        {
                            rjson = objValue.objToJson();
                        }
                    }


                }
                if (sb.Length > 0)
                {
                    if (sb.ToString().EndsWith("&"))
                    {
                        sb.Remove(sb.Length - 1, 1);
                    }
                    base.HttpMethodAttribute.Url = base.HttpMethodAttribute.Url + WeiXinUtils.BuildGetUrl(base.HttpMethodAttribute.Url
                  ) + sb.ToString();
                }
            }
            //创建菜单单独处理
            if (base.HttpMethodAttribute.Serialize == Attribute.SerializeVerb.Json)
            {
                rjson = Request.objToJson();
            }
            getJosn = webutils.DoPost(base.HttpMethodAttribute.Url, rjson);
            return getJosn.jsonToObj<T>();
        }
    }
}

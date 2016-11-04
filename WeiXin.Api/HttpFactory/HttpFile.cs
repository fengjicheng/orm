using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Runtime.Serialization;
using System.IO;
using Qhyhgf.WeiXin.Qy.Api.Request;
using Qhyhgf.WeiXin.Qy.Api.Response;
using Qhyhgf.WeiXin.Qy.Api.Helpers;
using Qhyhgf.WeiXin.Qy.Api.Attribute;
using Qhyhgf.WeiXin.Qy.Api.Dynamic;
namespace Qhyhgf.WeiXin.Qy.Api.HttpFactory
{
    /// <summary>
    /// 上传文件处理.
    /// </summary>
    public class HttpFile<T> : Http<T> where T : WeiXinResponse
    {
        public override T GetResponse()
        {
            //判断是否需要身份验证
            if (base.HttpMethodAttribute.IsToken)
            {
                base.HttpMethodAttribute.Url = base.HttpMethodAttribute.Url + WeiXinUtils.BuildGetUrl(base.HttpMethodAttribute.Url
                    ) + "access_token=" + base.Token.AccessToken;
            }
            WebUtils webutils = new WebUtils();
            //上传文件返回json
            if (HttpMethodAttribute.Serialize == SerializeVerb.Json)
            {
                Type type = base.Request.GetType();
                //获得多媒体路径.
                PropertyInfo infoMedia = type.GetProperty("Media");
                object objMedia = infoMedia.FastGetValue(base.Request);
               // object objMedia = infoMedia.GetValue(Request, null);
                string strPath = string.Empty;
                if (objMedia is string)
                {
                    strPath = objMedia as string;
                }
                //获得多媒体类型.
                PropertyInfo infoType = type.GetProperty("Type");
                object objType = infoType.FastGetValue(base.Request);
                Domain.MediaType mediaType = new Domain.MediaType();
                if (objType is Domain.MediaType)
                {
                    mediaType = (Domain.MediaType)objType;
                }
                ///如果路径不为空
                if (File.Exists(strPath))
                {
                    //在url里面添加文件类型
                    HttpMethodAttribute.Url += "&type=" + mediaType.ToString().ToLower();            
                    string strJson = webutils.DoPostFile(HttpMethodAttribute.Url, strPath);
                    return strJson.jsonToObj<T>();
                }
                else
                {
                    throw new WeiXinException(string.Format("你要上传的：{0}路径非法", strPath));
                }
            }
            ///返回byte 执行下载逻辑
            if (HttpMethodAttribute.Serialize== SerializeVerb.Byte)
            {
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
                        fieldValue = objValue.ToString();
                    }
                    FieldInfo fieldInfo = type.GetField(fieldName);
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
                if (sb.ToString().EndsWith("&"))
                {
                    sb.Remove(sb.Length - 1, 1);
                }
                ///得到请求Url
                base.HttpMethodAttribute.Url = base.HttpMethodAttribute.Url + WeiXinUtils.BuildGetUrl(base.HttpMethodAttribute.Url
                       ) + sb.ToString();
                string path = string.Empty;
                byte[] stream = webutils.Download(HttpMethodAttribute.Url, out path);
                GetMediaResponse response = new GetMediaResponse();
                response.Stream =BytesToStream(stream);
                response.Path = path;
                return response as T;
            }
            return null;  
        }
        /// <summary>
        /// 把字符数组转化为流
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        private Stream BytesToStream(byte[] bytes)
        {
            Stream stream = new MemoryStream(bytes);
            return stream;
        }
    }
}

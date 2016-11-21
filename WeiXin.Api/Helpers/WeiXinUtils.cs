using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

namespace Qhyhgf.WeiXin.Qy.Api.Helpers
{
    /// <summary>
    /// 微信工具类
    /// </summary>
    public abstract class WeiXinUtils
    {
        /// <summary>
        /// url编码；
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string UrlEncode(string str)
        {
            return System.Web.HttpUtility.UrlEncode(str, Encoding.UTF8);
        }
        /// <summary>
        /// 拼接AuthUrl地址用于企业获取code
        /// </summary>
        /// <param name="appid">企业的CorpID</param>
        /// <param name="redirect_uri"授权后重定向的回调链接地址，请使用urlencode对链接进行处理></param>
        /// <param name="state">重定向后会带上state参数，企业可以填写a-zA-Z0-9的参数值，长度不可超过128个字节</param>
        /// <returns></returns>
        public static string AauthJumpUrl(string appid,string redirect_uri,string state = null)
        {
            StringBuilder urls = new StringBuilder();
            urls.Append("https://open.weixin.qq.com/connect/oauth2/authorize?appid=");
            urls.Append(appid);
            urls.Append("&redirect_uri=");
            //授权后重定向的回调链接地址，请使用urlencode对链接进行处理
            urls.Append(UrlEncode(redirect_uri));
            urls.Append("&response_type=code&scope=SCOPE");
            if (!string.IsNullOrEmpty(state))
            {
                urls.Append("&state=");
                urls.Append(state);
            }
            urls.Append("#wechat_redirect");
            return urls.ToString();
        }
        /// <summary>
        /// 向页面输出js代码。
        /// </summary>
        /// <param name="javascript">要执行的代码</param>
        /// <param name="page"></param>
        private static void AddJavaScript(string javascript, Page page)
        {
            #region 执行的代码.

             string js = @"<script language='javascript'>{0}</script>";
            //HttpContext.Current.Response.Write(string.Format(js, message, toURL));
            if (!page.ClientScript.IsStartupScriptRegistered(page.GetType(), "Redirect"))
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "AlertAndRedirect",
                                                        string.Format(js,javascript));
            }

            #endregion
        }
        /// <summary>
        /// Url连接符
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string BuildGetUrl(string str)
        {
            if (str.Contains("?"))
            {
                str = "&";
            }
            else
            {
                str = "?";
            }
            return str;
        }
        /// <summary>
        /// 隐藏工具栏
        /// </summary>
        /// <param name="page"></param>
        public static void hideToolbar(Page page)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("function onBridgeReady(){\n");
            sb.Append("  WeixinJSBridge.call('hideToolbar');\n");
            sb.Append("}\n");
            sb.Append("if (typeof WeixinJSBridge == \"undefined\"){\n");
            sb.Append(" if( document.addEventListener ){\n");
            sb.Append("  document.addEventListener('WeixinJSBridgeReady', onBridgeReady, false);\n");
            sb.Append(" }else if (document.attachEvent){\n");
            sb.Append("  document.attachEvent('WeixinJSBridgeReady', onBridgeReady);\n");
            sb.Append("  document.attachEvent('onWeixinJSBridgeReady', onBridgeReady);\n");
            sb.Append("}\n");
            sb.Append("}else{\n");
            sb.Append(" onBridgeReady();\n");
            sb.Append("}\n");
            AddJavaScript(sb.ToString(), page);
        }
        /// <summary>
        /// 显示工具栏
        /// </summary>
        /// <param name="page"></param>
        public static void showToolbar(Page page)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("function onBridgeReady(){\n");
            sb.Append("  WeixinJSBridge.call('showToolbar');\n");
            sb.Append("}\n");
            sb.Append("if (typeof WeixinJSBridge == \"undefined\"){\n");
            sb.Append(" if( document.addEventListener ){\n");
            sb.Append("   document.addEventListener('WeixinJSBridgeReady', onBridgeReady, false);\n");
            sb.Append(" }else if (document.attachEvent){\n");
            sb.Append("  document.attachEvent('WeixinJSBridgeReady', onBridgeReady);\n");
            sb.Append("  document.attachEvent('onWeixinJSBridgeReady', onBridgeReady);\n");
            sb.Append(" }\n");
            sb.Append("}else{\n");
            sb.Append(" onBridgeReady();\n");
            sb.Append("}\n");
            AddJavaScript(sb.ToString(), page);
        }
        public static void getNetworkType(Page page, string res)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" function onBridgeReady(){\n");
            sb.Append("  WeixinJSBridge.invoke('getNetworkType',{},");
            sb.Append("  function(e){\n");
            sb.Append( res );
            sb.Append("	   WeixinJSBridge.log(e.err_msg);\n");
            sb.Append("  });\n");
            sb.Append("}\n");
            sb.Append("if (typeof WeixinJSBridge == \"undefined\"){\n");
            sb.Append("    if( document.addEventListener ){\n");
            sb.Append("        document.addEventListener('WeixinJSBridgeReady', onBridgeReady, false);\n");
            sb.Append("    }else if (document.attachEvent){\n");
            sb.Append("        document.attachEvent('WeixinJSBridgeReady', onBridgeReady); \n");
            sb.Append("        document.attachEvent('onWeixinJSBridgeReady', onBridgeReady);\n");
            sb.Append("    }\n");
            sb.Append("}else{\n");
            sb.Append("    onBridgeReady();\n");
            sb.Append("}\n");
            AddJavaScript(sb.ToString(), page);
        }
        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="page"></param>
        /// <param name="res"></param>
        public static void closeWindow(Page page, string res)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("WeixinJSBridge.invoke('closeWindow',{},function(res){ \n");
            sb.Append(res+"\n");
            sb.Append("});");

        }
        /// <summary>
        /// 字符串切割。
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        public static string[] SplitString(string original)
        {
            if (String.IsNullOrEmpty(original))
            {
                return new string[0];
            }

            var split = from piece in original.Split(',')
                        let trimmed = piece.Trim()
                        where !String.IsNullOrEmpty(trimmed)
                        select trimmed;
            return split.ToArray();
        }
        /// <summary>
        /// 获取文件的真实后缀名。目前只支持JPG, GIF, PNG, BMP四种图片文件。
        /// </summary>
        /// <param name="fileData">文件字节流</param>
        /// <returns>JPG, GIF, PNG or null</returns>
        public static string GetFileSuffix(byte[] fileData)
        {
            if (fileData == null || fileData.Length < 10)
            {
                return null;
            }

            if (fileData[0] == 'G' && fileData[1] == 'I' && fileData[2] == 'F')
            {
                return "GIF";
            }
            else if (fileData[1] == 'P' && fileData[2] == 'N' && fileData[3] == 'G')
            {
                return "PNG";
            }
            else if (fileData[6] == 'J' && fileData[7] == 'F' && fileData[8] == 'I' && fileData[9] == 'F')
            {
                return "JPG";
            }
            else if (fileData[0] == 'B' && fileData[1] == 'M')
            {
                return "BMP";
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取文件的真实媒体类型。目前只支持JPG, GIF, PNG, BMP四种图片文件。
        /// </summary>
        /// <param name="fileData">文件字节流</param>
        /// <returns>媒体类型</returns>
        public static string GetMimeType(byte[] fileData)
        {
            string suffix = GetFileSuffix(fileData);
            string mimeType;

            switch (suffix)
            {
                case "JPG": mimeType = "image/jpeg"; break;
                case "GIF": mimeType = "image/gif"; break;
                case "PNG": mimeType = "image/png"; break;
                case "BMP": mimeType = "image/bmp"; break;
                default: mimeType = "application/octet-stream"; break;
            }

            return mimeType;
        }

        /// <summary>
        /// 根据文件后缀名获取文件的媒体类型。
        /// </summary>
        /// <param name="fileName">带后缀的文件名或文件全名</param>
        /// <returns>媒体类型</returns>
        public static string GetMimeType(string fileName)
        {
            string mimeType;
            fileName = fileName.ToLower();

            if (fileName.EndsWith(".bmp", StringComparison.CurrentCulture))
            {
                mimeType = "image/bmp";
            }
            else if (fileName.EndsWith(".gif", StringComparison.CurrentCulture))
            {
                mimeType = "image/gif";
            }
            else if (fileName.EndsWith(".jpg", StringComparison.CurrentCulture) || fileName.EndsWith(".jpeg", StringComparison.CurrentCulture))
            {
                mimeType = "image/jpeg";
            }
            else if (fileName.EndsWith(".png", StringComparison.CurrentCulture))
            {
                mimeType = "image/png";
            }
            else
            {
                mimeType = "application/octet-stream";
            }

            return mimeType;
        }
        /// <summary>
        /// 获取从1970年1月1日到现在的毫秒总数。
        /// </summary>
        /// <returns>毫秒数</returns>
        public static long GetCurrentTimeMillis()
        {
            return (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;
        }
    }
}

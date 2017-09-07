using System;
using System.Web;

namespace Qhyhgf.WeiXin.Qy.Api
{
    
    public class RedirectAuthentication : IHttpHandler
    {
        #region 过期代码
        //public delegate void DAuthentication(string a);
        //public static event DAuthentication EAuthentication;
        ///// <summary>
        ///// 您将需要在您网站的 web.config 文件中配置此处理程序，
        ///// 并向 IIS 注册此处理程序，然后才能进行使用。有关详细信息，
        ///// 请参见下面的链接: http://go.microsoft.com/?linkid=8101007
        ///// </summary>
        //public static void Buding(DAuthentication delAuthent)
        //{
        //    EAuthentication += delAuthent;
        //}
        #endregion
        public bool IsReusable
        {
            // 如果无法为其他请求重用托管处理程序，则返回 false。
            // 如果按请求保留某些状态信息，则通常这将为 false。
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            string code = context.Request.QueryString["code"];
            if (string.IsNullOrEmpty(code))
            {
                throw new WeiXinException("微信服务器返回的code参数为空为空");
            }
            //获取成员信息
            //进行身份验证

            //在此写入您的处理程序实现。
        }
    }
}

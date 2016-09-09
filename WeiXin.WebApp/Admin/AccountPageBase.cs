using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeiXin.WebUi.Admin
{
    public class AccountPageBase : System.Web.UI.Page
    {
        public void WriteAjax(string _text)
        {
            Response.OutputStream.Close();
            Response.Write(_text);
            Response.End();
        }
        /// <summary>
        /// 页面权限判断
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            ///获得当前url地址
            string url = Request.Url.AbsolutePath;
            if (url!="/Admin/Login.aspx")
            {
                ///如果后台登陆的session为空
                if (Session["Account"]==null)
	            {
                    Response.Redirect("Login.aspx");
                    return;
	            } 
            }
            base.OnLoad(e);
        }
    }
}
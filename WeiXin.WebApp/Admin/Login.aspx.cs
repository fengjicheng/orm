using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WeiXin.WebUi.Admin
{
    public partial class Login : AccountPageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string action = Request.QueryString["action"]??string.Empty;
            switch (action.ToLower())
            {
                ///退出系统
                case "exit": exit(); break;
                //登陆系统
                case "login": onLogin(); break;
                default:
                    break;
            }
        }
        /// <summary>
        /// 登陆系统
        /// </summary>
        protected void onLogin()
        {
            string user = Request.Form["username"];
            string pwd = Request.Form["pwd"];
        }
        /// <summary>
        /// 退出系统
        /// </summary>
        protected void exit()
        {
            //清除所有的session数据
            Session.Clear();
            //跳转
            Response.Redirect("Login.aspx");
        }
    }
}
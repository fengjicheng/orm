using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Qhyhgf.WeiXin.Qy.Api;
using Qhyhgf.WeiXin.Qy.Api.Config;

namespace WeiXin.WebUi
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //#region webconfig读取
            //WeiXinSection section = WeiXinSection.GetInstance();
            
           
            //IWeiXinClient client = new DefaultWeiXinClient();
            //Qhyhgf.WeiXin.Qy.Api.Token.TokenEntity Entity = new Qhyhgf.WeiXin.Qy.Api.Token.ConfingToken().Handle("3010011");
            //#endregion
            //// Entity  = Qhyhgf.WeiXin.Qy.Api.Token.TokenManager.CreakDefault();
            //Qhyhgf.WeiXin.Qy.Api.Request.GetCheckInDataRequest getUserList = new Qhyhgf.WeiXin.Qy.Api.Request.GetCheckInDataRequest();
            //getUserList.StartTime = DateTime.Now.AddDays(-2);
            //getUserList.EndTime = DateTime.Now;
            //getUserList.OpenCheckInDataType = 3;
            //getUserList.UserIdList = new List<string> { "16338" };
            //client.Token = Entity;
            //Qhyhgf.WeiXin.Qy.Api.Response.GetCheckInDataResponse MediaUploadResponse = client.Execute<Qhyhgf.WeiXin.Qy.Api.Response.GetCheckInDataResponse>(getUserList);
        }
        /// <summary>
        /// 将DataTable中数据写入到CSV文件中
        /// </summary>
        /// <param name="dt">提供保存数据的DataTable</param>
        /// <param name="fileName">CSV的文件路径</param>
        public static void SaveCSV(List<Qhyhgf.WeiXin.Qy.Api.Domain.UserInfoEntity> reuser, string fullPath)
        {
            FileInfo fi = new FileInfo(fullPath);
            if (!fi.Directory.Exists)
            {
                fi.Directory.Create();
            }
            FileStream fs = new FileStream(fullPath, System.IO.FileMode.Create, System.IO.FileAccess.Write);
            //StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.Default);
            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8);
            string data = "";
            //写出列名称
            sw.WriteLine("姓名,帐号");
            //写出各行数据
            for (int i = 0; i < reuser.Count; i++)
            {
                data = "";
                Qhyhgf.WeiXin.Qy.Api.Domain.UserInfoEntity depItem = reuser[i];
                string str = depItem.Name;
                str = str.Replace("\"", "\"\"");//替换英文冒号 英文冒号需要换成两个冒号
                if (str.Contains(',') || str.Contains('"')
                    || str.Contains('\r') || str.Contains('\n')) //含逗号 冒号 换行符的需要放到引号中
                {
                    str = string.Format("\"{0}\"", str);
                }
                data += str;
                data += ",";
                data += depItem.UserId;
                sw.WriteLine(data);
            }
            sw.Close();
            fs.Close();
        }
    }
}
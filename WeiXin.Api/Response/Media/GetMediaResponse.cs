using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
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
namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    /// <summary>
    /// 获取媒体文件
    /// </summary>
    public class GetMediaResponse : WeiXinResponse
    {
        /// <summary>
        /// 多媒体保存的地址
        /// </summary>
        [DataMember(Name = "path")]
        public string Path { get; set; }
        [DataMember(Name = "stream")]
        public System.IO.Stream Stream { get; set; }
        public void SaveFile(string filePath)
        {
            if (Stream != null)
            {
                int len = 0;
                byte[] buf = new byte[8192];
                using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    while ((len = Stream.Read(buf, 0, buf.Length)) > 0)
                    {
                        fileStream.Write(buf, 0, len);
                    }
                }

            }
            else
            {
                throw new WeiXinException("要保存的内容为空!");
            }
        }
    }
}

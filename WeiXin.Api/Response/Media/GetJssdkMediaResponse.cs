using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.IO;

namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    /// <summary>
    /// 获取媒体文件
    /// </summary>
    public class GetJssdkMediaResponse : WeiXinResponse
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

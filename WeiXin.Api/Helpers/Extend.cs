using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
namespace Qhyhgf.WeiXin.Qy.Api.Helpers
{
    /// <summary>
    /// 扩展方法类
    /// </summary>
    public static class Extend
    {
        /// <summary>
        /// 转全角(SBC case)
        /// </summary>
        /// <param name="input">任意字符</param>
        /// <returns>处理结果</returns>
        public static string ToSBC(this string input)
        {
            char[] c = input.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 32)
                {
                    c[i] = (char)12288;
                    continue;
                }
                if (c[i] < 127)
                    c[i] = (char)(c[i] + 65248);
            }
            return new string(c);
        }
        public static string GetImageType(this byte[] imgb)
        {
            //JPEG/JPG - 文件头标识 (2 bytes): $ff, $d8 (SOI) (JPEG 文件标识) - 文件结束标识 (2 bytes): $ff, $d9 (EOI)
            if (imgb[0]== 0xff && imgb[1] == 0xd8 && imgb[imgb.Length-2] == 0xff && imgb[imgb.Length - 1] == 0xd9 )
            {
                return "JPEG/JPG";
            }
            //TGA - 未压缩的前5字节   00 00 02 00 00 - RLE压缩的前5字节   00 00 10 00 00
            if ((imgb[0] == 0 && imgb[1] == 0 && imgb[2] ==  2 && imgb[3] == 0 && imgb[4] == 0) ||
                (imgb[0] == 0 && imgb[1] == 0 && imgb[2] == 10 && imgb[3] == 0 && imgb[4] == 0))
            {
                return "TGA";
            }
            //PNG - 文件头标识 (8 bytes)   89 50 4E 47 0D 0A 1A 0A
            if (imgb[0] == 0x89 && imgb[1] == 0x50 && imgb[2] == 0x4e && imgb[3] == 0x47 &&
                imgb[4] == 0x0d && imgb[5] == 0x0a && imgb[6] == 0x1a && imgb[7] == 0x0a)
            {
                return "PNG";
            }
            //GIF - 文件头标识 (6 bytes)   47 49 46 38 39(37) 61                         G  I  F  8  9 (7)  a
            if (imgb[0] == 0x47 && imgb[1] == 0x49 && imgb[2] == 0x46 && imgb[3] == 0x38 &&
                (imgb[4] ==0x39 || imgb[4] == 0x37) && imgb[5] == 0x61)
            {
                return "GIF";
            }
            //BMP - 文件头标识 (2 bytes)   42 4D                         B  M
            if (imgb[0] == 0x42 && imgb[1] == 0x4d )
            {
                return "BMP";
            }
            //PCX - 文件头标识 (1 bytes)   0A
            if (imgb[0] == 0x0a)
            {
                return "PCX";
            }
            ///TIFF - 文件头标识 (2 bytes)  4D 4D 或 49 49
            if ((imgb[0] == 0x4d && imgb[1] == 0x4d)|| (imgb[0] == 0x49 && imgb[1] == 0x49))
            {
                return "TIFF";
            }
            //ICO - 文件头标识 (8 bytes)   00 00 01 00 01 00 30 30 
            if (imgb[0] == 0x00 && imgb[1] == 0x00 && imgb[2] == 0x01 && imgb[3] == 0x00 &&
                imgb[4] == 0x01 && imgb[5] == 0x00 && imgb[6] == 0x30 && imgb[7] == 0x30)
            {
                return "ICO";
            }
            //CUR - 文件头标识 (8 bytes)   00 00 02 00 01 00 20 20
            if (imgb[0] == 0x00 && imgb[1] == 0x00 && imgb[2] == 0x02 && imgb[3] == 0x00 &&
               imgb[4] == 0x01 && imgb[5] == 0x00 && imgb[6] == 0x20 && imgb[7] == 0x20)
            {
                return "CUR";
            }
            ///IFF - 文件头标识 (4 bytes)   46 4F 52 4D                        F  O  R  M
            if (imgb[0] == 0x46 && imgb[1] == 0x4f && imgb[2] == 0x52 && imgb[3] == 0x4d)
            {
                return "IFF";
            }
            //ANI - 文件头标识 (4 bytes)   52 49 46 46                         R  I  F  F
            if (imgb[0] == 0x52 && imgb[1] == 0x49 && imgb[2] == 0x46 && imgb[3] == 0x46)
            {
                return "IFF";
            }
            return string.Empty;

        }
        /// <summary>
        /// 转半角(DBC case)
        /// </summary>
        /// <param name="input">任意字符串</param>
        /// <returns>半角字符串</returns>
        public static string ToDBC(this string input)
        {
            char[] c = input.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 12288)
                {
                    c[i] = (char)32;
                    continue;
                }
                if (c[i] > 65280 && c[i] < 65375)
                    c[i] = (char)(c[i] - 65248);
            }
            return new string(c);
        }
        private const long STANDARD_TIME_STAMP = 621355968000000000;
        /// <summary>
        /// 转化为datatime
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static long ConvertToTimeStamp(this DateTime time)
        {
            return (DateTime.Now.ToUniversalTime().Ticks - STANDARD_TIME_STAMP) / 10000000;
        }
        /// <summary>
        /// 转化为datatime
        /// </summary>
        /// <param name="timestamp"></param>
        /// <returns></returns>
        public static DateTime ConvertToDateTime(this long timestamp)
        {
            return new DateTime(timestamp * 10000000 + STANDARD_TIME_STAMP).ToLocalTime();
        }
        /// <summary>
        /// json数据转化为对象
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="str">json本身</param>
        /// <returns>转化后的对象</returns>
        public static T jsonToObj<T>(this string str) where T : class
         {
             try
             {
                 T obj = default(T);
                 obj = JsonHelper.DeserializeObject<T>(str);
                 return obj;
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }
        /// <summary>
        /// 对象转化为json数据
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="obj">obj本身</param>
        /// <returns>返回的字符串</returns>
         public static string objToJson<T>(this T obj)
         {
             try
             {
                 return JsonHelper.SerializeObject<T>(obj) ;
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }
         public static T xmlToObj<T>(this string xml) where T : class
         {
             try
             {
                 T obj = default(T);
                 obj = XmlHelper.XmlDeserialize<T>(xml,Encoding.UTF8);
                 return obj;
             }
             catch (Exception ex)
             {
                 throw ex;
             }
 
         }
         /// <summary>
         /// 对象转化为json数据
         /// </summary>
         /// <typeparam name="T">类型</typeparam>
         /// <param name="obj">obj本身</param>
         /// <returns>返回的字符串</returns>
         public static string objToXml<T>(this T obj) where T : class
         {
             try
             {
                 return  XmlHelper.XmlSerialize(obj,Encoding.UTF8);
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }


    }
}

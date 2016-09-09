using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

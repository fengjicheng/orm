using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Qhyhgf.Orm.Extension
{
    /// <summary>
    /// string扩展
    /// </summary>
    public static class StringExtension
    {
        ///// <summary>
        ///// string 直接转化为guid
        ///// </summary>
        ///// <param name="s_guid"></param>
        ///// <returns></returns>
        //public static implicit operator Guid (string s_guid)
        //{
        //    Guid g_guid = new Guid(s_guid);
        //    return g_guid;
        //}
        #region 字符串查找
        /// <summary>
        /// 以忽略大小写的方式调用StartsWith
        /// </summary>
        /// <param name="str">源字符串</param>
        /// <param name="test">要测试的字符串</param>
        /// <returns>StartsWith的返回结果</returns>
        public static bool IgnoreCaseStartsWith(this string str, string test)
        {
            return str.StartsWith(test, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// 以忽略大小写的方式调用EndsWith
        /// </summary>
        /// <param name="str">源字符串</param>
        /// <param name="test">要测试的字符串</param>
        /// <returns>EndsWith的返回结果</returns>
        public static bool IgnoreCaseEndsWith(this string str, string test)
        {
            return str.EndsWith(test, StringComparison.OrdinalIgnoreCase);
        }
        /// <summary>
        /// 以忽略大小写的方式调用Compare
        /// </summary>
        /// <param name="str">源字符串</param>
        /// <param name="test">另一要比较的字符串</param>
        /// <returns>Compare的返回结果</returns>
        public static int IgnoreCaseCompare(this string str, string test)
        {
            return string.Compare(str, test, StringComparison.OrdinalIgnoreCase);
        }
        /// <summary>
        /// 以忽略大小写的方式调用IndexOf
        /// </summary>
        /// <param name="str">源字符串</param>
        /// <param name="test">另一要比较的字符串</param>
        /// <returns>IndexOf的返回结果</returns>
        public static int IgnoreCaseIndexOf(this string str, string test)
        {
            return str.IndexOf(test, StringComparison.OrdinalIgnoreCase);
        }
        #endregion
        #region 字符串转int
        /// <summary>
        /// 尝试将一个字符串转换成一个整形数字
        /// </summary>
        /// <param name="str">要转换的字符串</param>
        /// <param name="defaultVal">默认值</param>
        /// <returns>转换后的数字</returns>
        public static int TryToInt(this string str, int defaultVal)
        {
            int result;
            if (!int.TryParse(str, out result))
            {
                return defaultVal;
            }
            else
            {
                return result;
            }
        }
        /// <summary>
        /// 尝试将一个字符串转换成一个整形数字
        /// </summary>
        /// <param name="str">要转换的字符串</param>
        /// <returns>转换后的数字</returns>
        public static int TryToInt(this string str)
        {
            return str.TryToInt(0);
        }
        #endregion
        #region 字符串转decimal
        /// <summary>
		/// 尝试将一个字符串转换成一个金额数字
		/// </summary>
		/// <param name="str">要转换的字符串</param>
		/// <param name="defaultVal">默认值</param>
		/// <returns>转换后的数字</returns>
        public static decimal TryToDecimal(this string str, decimal defaultVal)
        {
            decimal result;
            if (!decimal.TryParse(str, out result))
            {
                return defaultVal;
            }
            else
            {
                return result;
            }
        }
        /// <summary>
        /// 尝试将一个字符串转换成一个金额数字
        /// </summary>
        /// <param name="str">要转换的字符串</param>
        /// <returns>转换后的数字</returns>
        public static decimal TryToDecimal(this string str)
        {
            return str.TryToDecimal(0m);
        }
        #endregion
        #region 字符串转DateTime
        /// <summary>
		/// 尝试将一个字符串转换成一个DateTime
		/// </summary>
		/// <param name="str">要转换的字符串</param>
		/// <param name="defaultVal">默认值</param>
		/// <returns>转换后的DateTime</returns>
        public static DateTime TryToDateTime(this string str, DateTime defaultVal)
        {
            DateTime result;
            if (!DateTime.TryParse(str, out result))
            {
                return defaultVal;
            }
            else
            {
                return result;
            }
        }
        /// <summary>
        /// 尝试将一个字符串转换成一个DateTime
        /// </summary>
        /// <param name="str">要转换的字符串</param>
        /// <returns>转换后的DateTime</returns>
        public static DateTime TryToDateTime(this string str)
        {
            return str.TryToDateTime(DateTime.Now);
        }
        #endregion
        #region hash算法
        /// <summary>
		/// 计算一个字符串的MD5值。
		/// </summary>
		/// <param name="input">要计算的字符串</param>
		/// <param name="encoding">编码方式</param>
		/// <returns>MD5值</returns>
        public static string GetMd5String(this string input, Encoding encoding)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            byte[] value = new MD5CryptoServiceProvider().ComputeHash(encoding.GetBytes(input));
            return BitConverter.ToString(value).Replace("-", "");
        }
        /// <summary>
		/// 计算一个字符串的SHA1值。
		/// </summary>
		/// <param name="input">要计算的字符串</param>
		/// <param name="encoding">编码方式</param>
		/// <returns>SHA1值</returns>
        public static string GetSha1String(this string input, Encoding encoding)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }
            byte[] value = new SHA1CryptoServiceProvider().ComputeHash(encoding.GetBytes(input));
            return BitConverter.ToString(value).Replace("-", "");
        }
        #endregion
        #region 判断字符串是否为guid
        /// <summary>
		/// 判断一个字符串是不是一个GUID的字符串
		/// </summary>
		/// <param name="str">要判断的字符串</param>
		/// <returns>是不是一个GUID的字符串</returns>
        public static bool IsGuid(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return false;
            }
            Regex reg = new Regex("^[A-F0-9]{8}(-[A-F0-9]{4}){3}-[A-F0-9]{12}$", RegexOptions.Compiled);
            return reg.IsMatch(str);
        }
        #endregion
        #region 安全地调用ChangeType方法（Try ChangeType）
        /// <summary>
		/// 安全地调用ChangeType方法（Try ChangeType）
		/// </summary>
		/// <typeparam name="T">要转换后的类型</typeparam>
		/// <param name="str">将要转换的字符串</param>
		/// <returns>转换后的结果</returns>
        public static T TryChangeType<T>(this string str) where T:class
        {
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }
            T result = default(T);
            try
            {
                result = (T)((object)Convert.ChangeType(str, typeof(T)));
                return result;
            }
            catch (Exception)
            {
                return result;
            }
        }
        #endregion
        #region 将一个十六进制的字符串转成byte[]
        /// <summary>
		/// 将一个十六进制的字符串转成byte[]
		/// </summary>
		/// <param name="hex">十六进制的字符串</param>
		/// <returns>转换后的byte[]</returns>
        public static byte[] HexToBin(string hex)
        {
            int len = (hex.Length / 2);
            byte[] result = new byte[len];
            char[] achar = hex.ToCharArray();
            for (int i = 0; i < len; i++)
            {
                int pos = i * 2;
                result[i] = (byte)(toByte(achar[pos]) << 4 | toByte(achar[pos + 1]));
            }
            return result;
        }
        private static byte toByte(char c)
        {
            byte b = (byte)"0123456789ABCDEF".IndexOf(c);
            return b;
        }
        #endregion
    }
}

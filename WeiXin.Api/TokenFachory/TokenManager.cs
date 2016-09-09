using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Qhyhgf.WeiXin.Qy.Api.Config;

namespace Qhyhgf.WeiXin.Qy.Api.TokenFachory
{
    public class TokenManager
    {
        private readonly static WeiXinSection section = WeiXinSection.GetInstance();
        private static TokenCollection collection = section.ToTokenCollection();
        /// <summary>
        /// 根据key创建Token对象
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static TokenEntity CreakToken(string key)
        {
            if (collection.Contains(key))
            {
                TokenEntity itme = collection[key];
                itme.GetAccessToken();
                return itme;
            }
            return null;
        }
        /// <summary>
        /// 获得默认的验证对象
        /// </summary>
        /// <returns></returns>
        public static TokenEntity CreakDefault()
        {
            if (collection.Count>0)
            {
                return collection[0];
            }
            return null;
        }
        /// <summary>
        /// 创建所有Token对象
        /// </summary>
        /// <returns></returns>
        public static TokenCollection CreakTokenCollection()
        {
            if (collection == null)
            {
                collection = section.ToTokenCollection();
            }
            foreach (var item in collection)
            {
                item.GetAccessToken();
            }
            return collection;
        }
    }
}

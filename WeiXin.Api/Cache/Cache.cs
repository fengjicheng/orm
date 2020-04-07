using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
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
namespace Qhyhgf.WeiXin.Qy.Api.Cache
{
    public class Cache : ICache
    {
        private static System.Web.Caching.Cache cache = HttpRuntime.Cache;

        /// <summary>
        /// 读取缓存
        /// </summary>
        /// <param name="cacheKey">键</param>
        /// <returns></returns>
        public T GetCache<T>(string cacheKey) where T : class
        {
            if (cache[cacheKey] != null)
            {
                return (T)cache[cacheKey];
            }
            return default(T);
        }
        /// <summary>
        /// 写入缓存
        /// </summary>
        /// <param name="value">对象数据</param>
        /// <param name="cacheKey">键</param>
        public void WriteCache<T>(T value, string cacheKey) where T : class
        {
            cache.Insert(cacheKey, value, null, DateTime.Now.AddMinutes(10), System.Web.Caching.Cache.NoSlidingExpiration);
        }
        /// <summary>
        /// 写入缓存
        /// </summary>
        /// <param name="value">对象数据</param>
        /// <param name="cacheKey">键</param>
        /// <param name="expireTime">到期时间</param>
        public void WriteCache<T>(T value, string cacheKey, DateTime expireTime) where T : class
        {
            cache.Insert(cacheKey, value, null, expireTime, System.Web.Caching.Cache.NoSlidingExpiration);
        }
        /// <summary>
        /// 移除指定数据缓存
        /// </summary>
        /// <param name="cacheKey">键</param>
        public void RemoveCache(string cacheKey)
        {
            cache.Remove(cacheKey);
        }
        /// <summary>
        /// 移除全部缓存
        /// </summary>
        public void RemoveCache()
        {
            IDictionaryEnumerator CacheEnum = cache.GetEnumerator();
            while (CacheEnum.MoveNext())
            {
                cache.Remove(CacheEnum.Key.ToString());
            }
        }
    }
}

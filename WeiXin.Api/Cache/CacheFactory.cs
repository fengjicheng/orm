using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Qhyhgf.WeiXin.Qy.Api.Cache
{
    public class CacheFactory
    {
        /// <summary>
        /// 定义通用的Repository
        /// 支持扩展，需要在配置文件中配置，程序命名空间，dll名称dll需要放入bin目录
        /// </summary>
        /// <returns></returns>
        public static ICache Cache()
        {
            //修改为支持Redis
            string cacheType = Config.WeiXinSection.GetInstance().CacheType;
            switch (cacheType)
            {
                case "RedisCache":
                    return new RedisCache();
                case "WebCache":
                    return new Cache();
                default:
                    //获取程序集路径
                    string assemblyFile = cacheType.Split(',')[1];
                    //程序集命名空间
                    string assemblyNamespace= cacheType.Split(',')[0];
                    Assembly assembly = Assembly.LoadFile(System.AppDomain.CurrentDomain.BaseDirectory+"\\"+assemblyFile);
                    object obj = assembly.CreateInstance(assemblyNamespace);
                    return obj as ICache;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Qhyhgf.Orm.Config;

namespace Qhyhgf.Orm.Utils
{
    /// <summary>
    /// 命中率扩展
    /// </summary>
    internal class AccuracyUtils
    {
        private int countReadAccuracy=0, countWriteAccuracy=0;
        private static AccuracyUtils instance;
        private IList<KeyValueSetting> arrRead =new List<KeyValueSetting>();
        private IList<KeyValueSetting> arrWrite = new List<KeyValueSetting>();
        private static readonly Section section = Section.GetInstance();
        /// <summary>
        /// 多线程锁
        /// </summary>
        private static  object objlock = new object();
        Random ran = new Random();
        /// <summary>
        /// 获得要读取的数据库串
        /// </summary>
        internal KeyValueSetting GetWriteCon
        {
            get {
                lock (objlock)
                {
                    int ldfnub = ran.Next(countWriteAccuracy);
                    int temp=0;
                    for (int i = 0; i < arrWrite.Count; i++)
                    {
                        temp += arrWrite[i].Accuracy;
                         if (ldfnub<temp)
                         {
                             return arrWrite[i];
                         }
                    }
                    //返回最后一个确保每次都能返回
                    return arrWrite[arrWrite.Count - 1];
                }
            }
        }
        /// <summary>
        /// 写的数据库字符串
        /// </summary>
        internal KeyValueSetting GetReadCon
        {
            get
            {
                lock (objlock)
                {
                    int ldfnub = ran.Next(countReadAccuracy);
                    int temp = 0;
                    for (int i = 0; i < arrRead.Count; i++)
                    {
                        temp += arrRead[i].Accuracy;
                        if (ldfnub < temp)
                        {
                            return arrRead[i];
                        }
                    }
                    //返回最后一个确保每次都能返回
                    return arrRead[arrRead.Count - 1];
                }
            }
        }
        public static AccuracyUtils GetInstance()
        {
            if (instance == null)
            {
                lock (objlock)
                {
                    if (instance == null)
                    {
                        instance = new AccuracyUtils();
                    }

                }

            }
            return instance;
        }
        /// <summary>
        /// 构造函数，读取配置文件的读写信息
        /// </summary>
        private AccuracyUtils() {
            Collection KeyValues = section.KeyValues;
            bool IsEncrypt = section.IsEncrypt;
            ///判断加密字符串是否为空
            if (IsEncrypt)
            {
                throw new ArgumentNullException("加密字符串为空");
            }
            foreach (var item in KeyValues)
            {
               var key=  item as KeyValueSetting;
               //如果连接字符串加密，则解密
               if (IsEncrypt)
               {
                   key.Conn = DESEncrypt.Decrypt(key.Conn, section.AESKey); 
               }
               if (key.Action == ActionType.Read)
               {
                   arrRead.Add(key);
                   countReadAccuracy += key.Accuracy;
               }
                   ///如果write
               else if (key.Action == ActionType.Write)
               {
                   arrWrite.Add(key);
                   countWriteAccuracy += key.Accuracy; 
               }
               else //如果为All
               {
                   arrRead.Add(key);
                   countReadAccuracy += key.Accuracy;
                   arrWrite.Add(key);
                   countWriteAccuracy += key.Accuracy; 
                  
               }
            }
            //判断读取数据配置中是否为空
            if (arrRead.Count < 1)
            {
                throw new ArgumentNullException("配置文件中，要读取的为空！");
            }
            if (arrWrite.Count < 1)
            {
                throw new ArgumentNullException("配置文件中，要写的为空！");
            }
        
        
        }
    }
}

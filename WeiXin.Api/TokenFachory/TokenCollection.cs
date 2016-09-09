using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Qhyhgf.WeiXin.Qy.Api.TokenFachory
{
    public class TokenCollection : ICollection<TokenEntity>, IEnumerable<TokenEntity>
    {
        IDictionary<string, TokenEntity> dic = new Dictionary<string, TokenEntity>();
        /// <summary>
        ///  添加token实体
        /// </summary>
        /// <param name="item"></param>
        public void Add(TokenEntity item)
        {
            //验证是否合格，
            item.Validate();
            if (dic.ContainsKey(item.AgentID))
            {
                dic[item.AgentID] = item;
            }
            else
            {
                dic.Add(item.AgentID, item);
            }
        }
        /// <summary>
        /// 索引器
        /// </summary>
        /// <param name="key">关键字</param>
        /// <returns></returns>
        public TokenEntity this[string key]
        {
            get
            {
                if (dic.ContainsKey(key))
                {
                    return dic[key];
                }
                return null;
            }
        }
        /// <summary>
        /// 索引器
        /// </summary>
        /// <param name="index">索引号</param>
        /// <returns></returns>
        public TokenEntity this[int index]
        {
            get
            {
                TokenEntity[] items = dic.Values.ToArray();
                return items[index];
            }
        }
        /// <summary>
        /// 清空数据
        /// </summary>
        public void Clear()
        {
            dic.Clear();
        }
        /// <summary>
        /// 查询是否存在
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(TokenEntity item)
        {
            return dic.ContainsKey(item.AgentID);
        }
        /// <summary>
        /// 查询是否存在
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Contains(string key)
        {
            return dic.ContainsKey(key);
        }
        public void CopyTo(TokenEntity[] array, int arrayIndex)
        {
            TokenEntity[] items = dic.Values.ToArray();
            for (int i = arrayIndex; i < items.Count(); i++)
            {
                array[i - arrayIndex] = items[i];
            }
        }
        /// <summary>
        /// 数量
        /// </summary>
        public int Count
        {
            get { return dic.Count; }
        }

        public bool IsReadOnly
        {
            get { return dic.IsReadOnly; }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove(TokenEntity item)
        {
            if (dic.ContainsKey(item.AgentID))
            {
                return dic.Remove(item.AgentID);
            }
            else
            {
                return false;
            }
        }

        public IEnumerator<TokenEntity> GetEnumerator()
        {
            foreach (TokenEntity item in dic.Values)
            {
                yield return item;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();  
        }
        /// <summary>
        /// 迭代器接口
        /// </summary>
        /// <returns></returns>
        IEnumerator<TokenEntity> IEnumerable<TokenEntity>.GetEnumerator()
        {
            return dic.Values.GetEnumerator();
        }
    }
}

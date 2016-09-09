using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Qhyhgf.WeiXin.Qy.Api.Helpers;

namespace Qhyhgf.WeiXin.Qy.Api.TokenFachory
{
    public class TokenEntity:IDisposable
    {
        /// <summary>
        /// 最后一次请求时间。
        /// </summary>
        public DateTime EndRequest { get; set; }
        public string EncodingAESKey { get; set; }
        //线程锁
        private object objLock = new object();
        /// <summary>
        /// 超时时间
        /// </summary>
        private static int _timeout =7200;
        //获得的token
        public string Token { get; set; }
        public string AgentID { get; set; }
        public string Secret { get; set; }
        public string CorpID { get; set; }
        public string Name { get; set; }
        public string AccessToken { get; set; }
        /// <summary>
        /// 获得token
        /// </summary>
        public void GetAccessToken()
        {
            //数据验证
            Validate();
            //如果_access_token存在，并未超时，直接返回
            if (!string.IsNullOrEmpty(Token) || EndRequest > DateTime.Now.AddSeconds(-_timeout))
            {
                lock (objLock)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("https://qyapi.weixin.qq.com/cgi-bin/gettoken?corpid=");
                    sb.Append(CorpID);
                    sb.Append("&corpsecret=");
                    sb.Append(Secret);
                    ///http请求
                    WebUtils webutils = new WebUtils();
                    string strGet = webutils.DoGet(sb.ToString());
                    Domain.TokenEntity token = strGet.jsonToObj<Domain.TokenEntity>();
                    if (token.ErrCode!=0)
                    {
                        throw new WeiXinException(token.ErrCode);
                    }
                    AccessToken = token.AccessToken;
                    _timeout = token.ExpiresIn;
                }
            }
        }
        /// <summary>
        /// 数据验证
        /// </summary>
        public void Validate()
        {
            if (string.IsNullOrEmpty(AgentID))
            {
                throw new WeiXinException("Key为空");
            }
            if (string.IsNullOrEmpty(Secret))
            {
                throw new WeiXinException("Secret为空");
            }
            if (string.IsNullOrEmpty(CorpID))
            {
                throw new WeiXinException("CorpID为空");
            }
            if (string.IsNullOrEmpty(Name))
            {
                throw new WeiXinException("Name为空");
            }
        }
        /// <summary>
        /// 线程销毁
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private bool m_disposed;
        protected virtual void Dispose(bool disposing)
        {
            if (!m_disposed)
            {
                if (disposing)
                {
                    // Release managed resources
                }
                // Release unmanaged resources
                m_disposed = true;
            }
        }
    }
}

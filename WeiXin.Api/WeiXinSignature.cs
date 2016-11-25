using System;
using System.Web;
using System.Configuration;
using System.Web.SessionState;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Qhyhgf.WeiXin.Qy.Api.Config;
using Qhyhgf.WeiXin.Qy.Api.Helpers;
using Qhyhgf.WeiXin.Qy.Api.Crypt;
using Qhyhgf.WeiXin.Qy.Api.Token;

namespace Qhyhgf.WeiXin.Qy.Api
{
    public class WeiXinSignature : IHttpHandler,IRequiresSessionState, IReadOnlySessionState 
    {
        /// <summary>
        /// 您将需要在您网站的 web.config 文件中配置此处理程序，
        /// 并向 IIS 注册此处理程序，然后才能进行使用。有关详细信息，
        /// 请参见下面的链接: http://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpHandler Members
        private Iloger log = new DefaultLoggercs();

        public bool IsReusable
        {
            // 如果无法为其他请求重用托管处理程序，则返回 false。
            // 如果按请求保留某些状态信息，则通常这将为 false。
            get { return true; }
        }
        /// <summary>
        /// 微信地址验证.
        /// </summary>
        /// <param name="context"></param>
        public void ProcessRequest(HttpContext context)
        {
            log.Error("\n");
            log.Error(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss   url:"));
            log.Error(context.Request.Url.ToString());
            string method = context.Request.HttpMethod;
            //获取AgentID
            string agentID = context.Request.QueryString["AgentID"];
            if (string.IsNullOrEmpty(agentID))
            {
                agentID = "0";
            }
            //根据AgentID 获取配置信息
            TokenManager manger = new TokenManager();
            TokenEntity entiy = manger.GetToken(agentID);
            WXBizMsgCrypt crypt = new WXBizMsgCrypt(entiy.Token, entiy.EncodingAESKey, entiy.CorpID);
            //微信服务器将对服务器进行get请求，判断参数
            #region GET执行动作（服务器验证）
            if (method == "GET")
            {
                VerifyURL(crypt, context);
            }
            #endregion
            #region POST执行动作（微信发过来的消息）
            else
            {
               string  postString = GetPostString(crypt,context);
               
            }
            #endregion
            //在此写入您的处理程序实现。
        }
        #region 辅助方法
        /// <summary>
        /// 自动回复
        /// </summary>
        /// <param name="_crypt"></param>
        /// <param name="_context"></param>
        /// <param name="message"></param>
        public void WriteData(WXBizMsgCrypt _crypt, HttpContext _context,string message)
        {
            string msg_signature = _context.Request.QueryString["msg_signature"];
            string timestamp = _context.Request.QueryString["timestamp"];
            string nonce = _context.Request.QueryString["nonce"];
            _context.Response.ContentType = "text/xml";
            _context.Response.ContentEncoding = Encoding.UTF8;
            int ret = _crypt.EncryptMsg(msg_signature, timestamp, nonce, ref message);
            if (ret != 0)
            {
                throw new WeiXinException("ERR: Decrypt fail, ret: " + ret);
            }
            _context.Response.Write(message);
            _context.Response.End();
        }
        private string GetPostString(WXBizMsgCrypt _crypt, HttpContext _context)
        {
            string msg_signature = _context.Request.QueryString["msg_signature"];
            string timestamp = _context.Request.QueryString["timestamp"];
            string nonce = _context.Request.QueryString["nonce"];
            StreamReader reader = new StreamReader(HttpContext.Current.Request.InputStream);
            string postString = reader.ReadToEnd();
            string sMsg = string.Empty;
            int ret = _crypt.DecryptMsg(msg_signature, timestamp, nonce, postString, ref sMsg);
            if (ret != 0)
            {
               throw new WeiXinException("ERR: Decrypt fail, ret: " + ret);
            }
            return sMsg;
        }
        private void WriteMeasge(WXBizMsgCrypt _crypt, HttpContext _context,string msgxml)
        {
            string msg_signature = _context.Request.QueryString["msg_signature"];
            string timestamp = _context.Request.QueryString["timestamp"];
            string nonce = _context.Request.QueryString["nonce"];
            string encrypMsgxml = string.Empty;
            int ret = _crypt.EncryptMsg(msgxml, timestamp, nonce, ref encrypMsgxml);
            if (ret != 0)
            {
                throw new WeiXinException("ERR: Decrypt fail, ret: " + ret);
            }
            else
            {
                _context.Response.Write(encrypMsgxml);
            }
        }
        /// <summary>
        /// 获得section
        /// </summary>
        /// <returns></returns>
        private WeiXinSection getSection()
        {
            WeiXinSection section = WeiXinSection.GetInstance();
            try
            {
                if (string.IsNullOrEmpty(section.CorpID))
                {
                    throw new WeiXinException("配置参数CorpID有误！");
                }
                return section;
            }
            catch (Exception ex)
            {
                throw ex;
            }
 
        }
        /// <summary>
        /// 验证url地址
        /// </summary>
        /// <param name="_crypt"></param>
        /// <param name="_context"></param>
        private void VerifyURL(WXBizMsgCrypt _crypt, HttpContext _context)
        {
            string msg_signature = _context.Request.QueryString["msg_signature"];
            string timestamp = _context.Request.QueryString["timestamp"];
            string nonce = _context.Request.QueryString["nonce"];
            string echostr = _context.Request.QueryString["echostr"];
            //判断这四个参数是否为空。
            if (!string.IsNullOrEmpty(echostr) && !string.IsNullOrEmpty(msg_signature) && !string.IsNullOrEmpty(nonce))
            {
                string sReplyEchoStr = string.Empty;
                int result = _crypt.VerifyURL(msg_signature, timestamp, nonce, echostr, ref sReplyEchoStr);
                if (result == 0)
                {
                    //验证成功
                    _context.Response.Write(sReplyEchoStr);
                }
                else
                {
                    _context.Response.Write("您不是微信服务器，请您绕道前行！");
                }

            }
            else
            {
                _context.Response.Write("您不是微信服务器，请您绕道前行！");
            }
        }
        #endregion
        #endregion
    }
}

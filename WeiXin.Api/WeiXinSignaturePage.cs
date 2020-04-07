using Qhyhgf.WeiXin.Qy.Api.Crypt;
using Qhyhgf.WeiXin.Qy.Api.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using Qhyhgf.WeiXin.Qy.Api.Helpers;
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
namespace Qhyhgf.WeiXin.Qy.Api
{
    public class WeiXinSignaturePage:System.Web.UI.Page
    {
        /// <summary>
        /// Token值
        /// </summary>
        public string Token { get; set; }
        /// <summary>
        /// EncodingAESKey值
        /// </summary>
        public string EncodingAESKey { get; set; }
        /// <summary>
        /// CorpID值
        /// </summary>
        public string CorpID { get; set; }
        protected override void OnInit(EventArgs e)
        {
            string method = Context.Request.HttpMethod;
            #region 验证是否缺少参数
            if (string.IsNullOrEmpty(Token))
            {
                throw new WeiXinException("Token为空");
            }
            if (string.IsNullOrEmpty(EncodingAESKey))
            {
                throw new WeiXinException("EncodingAESKey为空");
            }
            if (string.IsNullOrEmpty(CorpID))
            {
                throw new WeiXinException("CorpID为空");
            }
            #endregion
            #region GET执行动作（服务器验证）
            WXBizMsgCrypt crypt = new WXBizMsgCrypt(Token, EncodingAESKey,CorpID);
            if (method == "GET")
            {
                VerifyURL(crypt, Context);
            }
            #endregion
            #region POST执行动作（微信发过来的消息）
            else
            {
                ///获得微信传过来的xml
                string postString = GetPostString(crypt, Context);
                ///得到基础信息
                BaseMessage baseMessage = postString.xmlToObj<BaseMessage>();


            }
            #endregion

            //base.OnInit(e);
        }
        /// <summary>
        /// 获得微信服务器post过来消息
        /// </summary>
        /// <param name="_crypt"></param>
        /// <param name="_context"></param>
        /// <returns></returns>
        public string GetPostString(WXBizMsgCrypt _crypt, HttpContext _context)
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
        /// <summary>
        /// 返回消息
        /// </summary>
        /// <param name="_crypt"></param>
        /// <param name="_context"></param>
        /// <param name="msgxml"></param>
        public void WriteMeasge(WXBizMsgCrypt _crypt, HttpContext _context, string msgxml)
        {
            string msg_signature = _context.Request.QueryString["msg_signature"];
            string timestamp = _context.Request.QueryString["timestamp"];
            string nonce = _context.Request.QueryString["nonce"];
            _context.Response.ContentType = "text/xml";
            _context.Response.ContentEncoding = Encoding.UTF8;
            _context.Response.Clear();
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
        /// 验证url地址
        /// </summary>
        /// <param name="_crypt"></param>
        /// <param name="_context"></param>
        public void VerifyURL(WXBizMsgCrypt _crypt, HttpContext _context)
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
    }
}

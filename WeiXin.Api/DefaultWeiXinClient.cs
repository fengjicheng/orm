using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using Qhyhgf.WeiXin.Qy.Api.Helpers;
using Qhyhgf.WeiXin.Qy.Api.Attribute;
using Qhyhgf.WeiXin.Qy.Api.Config;
using Qhyhgf.WeiXin.Qy.Api.HttpFactory;
using Qhyhgf.WeiXin.Qy.Api.Token;
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
    public class DefaultWeiXinClient : IWeiXinClient
    {
        private TokenEntity _Token;
        /// <summary>
        /// 身份标示。
        /// </summary>
        public TokenEntity Token
        {
            get
            {
                return _Token;
            }
            set
            {
                _Token = value;
            }
        }
        /// <summary>
        /// 执行方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public T Execute<T>(IWeiXinRequest<T> request) where T : WeiXinResponse
        {
            //获得httpMethodAttribute数据.
            Type info = request.GetType();
            var HttpAttributeInfo = (HttpMethodAttribute)System.Attribute.GetCustomAttribute(info, typeof(HttpMethodAttribute));
            ///根据不同的请求方式
            Http<T> http = HttpFactory<T>.CreateHttp(HttpAttributeInfo.Method);
            //延签消息
            http.Token = Token;
            http.HttpMethodAttribute = HttpAttributeInfo;
            http.Request = request;
            return http.GetResponse();
        }
    }
}

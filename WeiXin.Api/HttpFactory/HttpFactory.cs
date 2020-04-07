using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Qhyhgf.WeiXin.Qy.Api.Attribute;
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
namespace Qhyhgf.WeiXin.Qy.Api.HttpFactory
{
    /// <summary>
    /// Http请求工厂
    /// </summary>
    public class HttpFactory<T> where T : WeiXinResponse
    {
        public static Http<T> CreateHttp(HttpVerb Method)
        {
             Http<T> http = null;
             switch (Method)
             {
                 //get请求
                 case HttpVerb.Get:
                     http = new HttpGet<T>();
                     break;
                 //post请求
                 case HttpVerb.Post:
                     http = new HttpPost<T>();
                     break;
                 //上传文件
                 case HttpVerb.File:
                     http = new HttpFile<T>();
                     break;
             }
             return http;
        }
    }
}

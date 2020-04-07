using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
namespace Qhyhgf.WeiXin.Qy.Api.Attribute
{
    /// <summary>
    ///请求参数(Qequest)要序列化类型;
    /// </summary>
    [Flags]
    public enum SerializeVerb:byte
    {
        /// <summary>
        /// JSON字符串
        /// </summary>
        Json = 1 << 0,
        /// <summary>
        /// XML字符串
        /// </summary>
        Xml = 1 << 1,
        /// <summary>
        /// 字节流
        /// </summary>
        Byte = 1 << 2,
        /// <summary>
        /// 不序列化直接返回
        /// </summary>
        None = 1 << 3
    }
}

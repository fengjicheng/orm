﻿using System;
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
[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace Qhyhgf.WeiXin.Qy.Api.Helpers
{
    /// <summary>
    /// 日志功能
    /// </summary>
    public class DefaultLoggercs:Iloger
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(DefaultLoggercs));
        void Iloger.Error(string message)
        {
            log.Error(message);
            Console.WriteLine(message);
        }

        void Iloger.Warn(string message)
        {
            log.Warn(message);
            Console.WriteLine(message);
        }

        void Iloger.Info(string message)
        {
            log.Info(message);
            Console.WriteLine(message);
        }

        void IDisposable.Dispose()
        {

        }
    }
}

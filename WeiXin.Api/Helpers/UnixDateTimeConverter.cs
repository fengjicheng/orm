using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
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
namespace Qhyhgf.WeiXin.Qy.Api.Helpers
{
    /// <summary>
    /// UTC时间戳扩展
    /// </summary>
    public class UnixDateTimeConverter : DateTimeConverterBase
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.Integer)
            {
                throw new Exception(String.Format("日期格式错误,got {0}.", reader.TokenType));
            }
            var ticks = (long)reader.Value;
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(ticks + "0000000");
            TimeSpan toNow = new TimeSpan(lTime);
            return dtStart.Add(toNow);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            long ticks;
            if (value is DateTime)
            {
                var epoc = new DateTime(1970, 1, 1);
                var delta = ((DateTime)value) - epoc;
                if (delta.TotalSeconds < 0)
                {
                    throw new ArgumentOutOfRangeException("时间格式错误.1");
                }
                ticks = (long)delta.TotalSeconds;
            }
            else
            {
                throw new Exception("时间格式错误.2");
            }
            writer.WriteValue(ticks);
        }
    }
}

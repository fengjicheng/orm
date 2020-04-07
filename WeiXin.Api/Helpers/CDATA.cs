using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml.Schema;
using System.Xml;
using Qhyhgf.WeiXin.Qy.Api.Domain;
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
    [Serializable]
    public class CDATA<T> : IXmlSerializable
    {
        private T _value;

		public CDATA() { }

        public CDATA(T value)
		{
			this._value = value;
		}

        public T Value
		{
			get { return _value; }
		}

		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}
        /// <summary>
        /// 转化过程
        /// </summary>
        /// <param name="reader"></param>
		void IXmlSerializable.ReadXml(XmlReader reader)
		{
            T objT = default(T);
            if (objT is MessageType || objT is EventType)
            {
                string temp = reader.ReadElementContentAsString();
                object oj = Enum.Parse(objT.GetType(), temp, true);
                objT = (T)oj;
                _value = objT;
            }
            else
            {
                object temp = reader.ReadElementContentAsObject();
                objT = (T)temp;
                _value = objT;
            }
            
		}

		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
            if (Value is MessageType)
            {
                writer.WriteCData(this._value.ToString().ToLower());
            }
            else
            {
                writer.WriteCData(this._value.ToString());
            }
			
		}

		public override string ToString()
		{
			return this._value.ToString();
		}

        public static implicit operator CDATA<T>(T text)
		{
			return new CDATA<T>(text);
		}
    }

}

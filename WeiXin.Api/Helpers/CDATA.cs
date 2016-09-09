using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml.Schema;
using System.Xml;
using Qhyhgf.WeiXin.Qy.Api.Domain;

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

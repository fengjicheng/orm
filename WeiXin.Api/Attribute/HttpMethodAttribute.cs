using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qhyhgf.WeiXin.Qy.Api.Attribute
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public sealed class HttpMethodAttribute : System.Attribute
    {
        public HttpMethodAttribute() {
            IsToken = false;
        }
        /// <summary>
        /// 请求类型
        /// </summary>
        public HttpVerb Method { get; set;}
        /// <summary>
        /// 是否需Token验证信息（默认否）
        /// </summary>
        public bool IsToken { get; set; }
        /// <summary>
        /// 接口请求地址
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// Api名字
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Request数据序列化类型
        /// </summary>
        public SerializeVerb Serialize { get; set; }
        /// <summary>
        /// 验证参数
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            return !string.IsNullOrEmpty(Url);
        }
    }
}

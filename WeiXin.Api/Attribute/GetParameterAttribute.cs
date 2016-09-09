using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Qhyhgf.WeiXin.Qy.Api.Attribute
{
    /// <summary>
    /// Get请求参数
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class GetParameterAttribute : System.Attribute
    {
        /// <summary>
        /// 是否必填字段
        /// </summary>
        public bool IsRequired { get;set;}
        /// <summary>
        /// 参数名称
        /// </summary>
        public string Name { get; set; }
        public GetParameterAttribute()
        {
        }
    }
}

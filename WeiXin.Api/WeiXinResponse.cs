using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace Qhyhgf.WeiXin.Qy.Api
{
    /// <summary>
    /// 请求基类
    /// </summary>
    [Serializable]
    [DataContract]
    public abstract class WeiXinResponse{
        /// <summary>
        /// 返回码
        /// </summary>
        [DefaultValue(0)]
        [DataMember(Name = "errcode",IsRequired=false)]
        public long ErrCode { get; set; }
        /// <summary>
        /// 对返回码的文本描述内容
        /// </summary>
        [DataMember(Name = "errmsg",IsRequired=false)]
        public string ErrMsg { get; set; }
        public override string ToString()
        {
            return string.Format("请求接口错误，错误代码：{0}，说明：{1}",ErrCode,ErrMsg);
        }

    }
}

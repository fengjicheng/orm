using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qhyhgf.WeiXin.Qy.Api
{
    /// <summary>
    /// TOP请求接口。
    /// </summary>
    public interface IWeiXinRequest<T> where T : WeiXinResponse
    {
        #region 过期代码，使用HttpMethodAttribute替代，更简洁。
        ///// <summary>
        ///// 请求方式Post Get File三种方式
        ///// </summary>
        //string Method { get; }
        ///// <summary>
        ///// Url地址
        ///// </summary>
        //string Url { get; }
        ///// <summary>
        ///// 获取WeiXin的API名称。
        ///// </summary>
        ///// <returns>API名称</returns>
        //string GetApiName();
       
        ///// <summary>
        ///// 请求参数
        ///// </summary>
        ///// <returns></returns>
        //string GetGetParameters();

        ///// <summary>
        ///// 提前验证参数。
        ///// </summary>
        //bool Validate();
        #endregion
    }
}

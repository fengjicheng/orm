/*----------------------------------------------------------------
 * 作者：冯际成
 * 时间：2016年9月5日
 * ----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qhyhgf.Orm.Page
{
    public interface IPage
    {
        /// <summary>
        /// 记录总数
        /// </summary>
        int RecordCount { get;  set; }
        /// <summary>
        /// 每页记录数
        /// </summary>
        int PageSize { get; set; }
        /// <summary>
        /// 总页数
        /// </summary>
        int PageCount { get; }
        /// <summary>
        /// 当前页数
        /// </summary>
        int PageIndex { get; set; }
        /// <summary>
        /// 是否为首页
        /// </summary>
        bool IsFirstPage { get; }
        /// <summary>
        ///  是否为尾页
        /// </summary>
        bool IsLastPage { get;}

        /// <summary>
        /// 排序字段（默认主键）
        /// </summary>
        string OrderBy{get;set;}

        //排序类型
        SortType SortType{get;set;}
    }
}

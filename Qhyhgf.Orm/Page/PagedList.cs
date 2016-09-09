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
    /// <summary>
    /// 分页类
    /// </summary>
    public class PagedList: IPage
    {
        private int _RecordCount=0;
        /// <summary>
        /// 记录总条数
        /// </summary>
        public int RecordCount
        {
            get
            {
                return _RecordCount;
            }
            set
            {
                _RecordCount = value;
            }
        }
        private int _PageSize=10;
        /// <summary>
        /// 每页记录数量默认10条
        /// </summary>
        public int PageSize
        {
            get
            {
                return _PageSize;
            }
            set
            {
                _PageSize = value;
            }
        }
        /// <summary>
        /// 记录总页数
        /// </summary>
        public int PageCount
        {
            get
            {
                return RecordCount % PageSize == 0 ? (RecordCount / PageSize) : (RecordCount / PageSize + 1);
            }
        }
        private int _PageIndex;
        /// <summary>
        /// 当前页码
        /// </summary>
        public int PageIndex
        {
            get
            {
                return _PageIndex;
            }
            set
            {
                _PageIndex = value;
            }
        }
        /// <summary>
        /// 是否首页
        /// </summary>
        public bool IsFirstPage
        {
            get
            {
                return PageIndex == 1;
            }
        }
        /// <summary>
        /// 是否为尾页
        /// </summary>
        public bool IsLastPage
        {
            get
            {
                return PageIndex == PageCount;
            }
        } 
        /// <summary>
        /// 排序字段
        /// </summary>
        public string OrderBy
        {
            get;
            set;
        }
        //排序方式
        public SortType SortType
        {
            get;
            set;
        }
    }
}

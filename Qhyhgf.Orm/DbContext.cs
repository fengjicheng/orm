using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using Qhyhgf.Orm.ExpressionEx;
using Qhyhgf.Orm.Page;
using System.Data.Common;

namespace Qhyhgf.Orm
{
    public class DbContext<TEntity> : IDisposable where TEntity : class
    {
        private DbConnection _Connection;
        /// <summary>
        /// 连接字符串
        /// </summary>
        public DbConnection Connection
        {
            get
            {
                return this._Connection;
            }
        }
        private DbTransaction _Transaction;
        /// <summary>
        /// 事物
        /// </summary>
        public DbTransaction Transaction
        {
            get
            {
                return this._Transaction;
            }
        }
        public string _ParamNamePrefix;
        public string ParamNamePrefix
        {
            get
            {
                return this._ParamNamePrefix;
            }
        }
        /// <summary>
        /// 连接字符串
        /// </summary>
        private string _configName;
        /// <summary>
        ///注册数据库连接 
        /// </summary>
        /// <param name="configName">配置名称</param>
        /// <param name="providerName">连接属性</param>
        /// <param name="cmdParamNamePrefix">前缀</param>
        /// <param name="defaultConnString">连接字符串</param>
        public static void  RegisterDbConnectionInfo(string configName, string providerName, string cmdParamNamePrefix, string defaultConnString)
        {
            if (string.IsNullOrEmpty(defaultConnString))
            {
                throw new ArgumentNullException("defaultConnString");
            }
            if (string.IsNullOrEmpty(configName))
            {
                throw new ArgumentNullException("configName");
            }
            if (string.IsNullOrEmpty(providerName))
            {
                throw new ArgumentNullException("providerName");
            }
            if (string.IsNullOrEmpty(cmdParamNamePrefix))
            {
                throw new ArgumentNullException("cmdParamNamePrefix");
            }
        }
        /// <summary>
        /// 获取所有数据
        /// </summary>
        /// <returns></returns>
        public static SqlQuery<TEntity> Get() 
        {
            SqlQuery<TEntity> entity = new SqlQuery<TEntity>(Expre2Sql.Select<TEntity>());  
            return entity;
        }

        /// <summary>
        /// 根据指定的查询条件
        /// </summary>
        /// <param name="expression">查询条件</param>
        /// <returns></returns>
        public static SqlQuery<TEntity> Get(Expression<Func<TEntity, bool>> expression) 
        {
            return null;
        }

        /// <summary>
        /// 根据指定条件查询分页数据
        /// </summary>
        /// <typeparam name="TOrderType">排序类型</typeparam>
        /// <param name="expression">查询条件</param>
        /// <param name="orderPropertyName">排序字段</param>
        /// <param name="isAscOrder">是否是升序查询</param>
        /// <param name="pgIndex"></param>
        /// <param name="pgSize"></param>
        /// <param name="total">总记录数</param>
        /// <returns></returns>
        [Obsolete("建议使用 IQueryable<TEntity> Get(EFQueryParam<TEntity> queryParam, out int total) 方法")]
        public static SqlQuery<TEntity> Get(Expression<Func<TEntity, bool>> expression,
            string orderPropertyName, bool isAscending,
            int pgIndex, int pgSize, out int total) 
        {
            total = 1;
            return null;
        }
        public static SqlQuery<TEntity> Get(Expression<Func<TEntity, bool>> expression,IPage page)
        {
            return null;
        }

        /// <summary>
        /// 根据指定条件查询数据
        /// </summary>
        /// <param name="queryParam">查询条件</param>
        /// <param name="total">符合条件的总记录数,该返回值在参数IsPagingQuery为true值时才有效</param>
        /// <returns></returns>
        // IEnumerable<TEntity> Get(EFQueryParam<TEntity> queryParam, out int total);

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        void Add(TEntity entity)
        {
 
        }
        /// <summary>
        /// 根据具体实体删除
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TEntity entity)
        { 
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        void Update(TEntity entity) 
        {
        }

        /// <summary>
        /// 根据主键获取
        /// </summary>
        /// <param name="id">主键Id值</param>
        /// <returns></returns>
        TEntity Get(params object[] ids)
        {
            return null;
        }

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="entity">主键Id值</param>
        void Delete(params object[] ids)
        { 
        }

        /// <summary>
        /// 保存数据修改
        /// </summary>
        void SaveDbChange()
        { 
        }
        #region Dispose方法实现

        bool _disposed;

        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            _disposed = true;
            //挂起终结器
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}

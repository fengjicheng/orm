using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace Qhyhgf.Orm.Repository
{

    /// <summary>
    ///  仓储模型基本接口,提供基本的数据库增删改查接口
    /// </summary>
    /// <typeparam name="TEntity">实体类型</typeparam>
    public interface IRepository<TEntity> : IDisposable where TEntity : BaseEntity
    {
        /// <summary>
        /// 根据主键id查询实体
        /// </summary>
        /// <param name="Uid"></param>
        /// <returns></returns>
        TEntity GetById(Guid Uid);

        IEnumerable<TEntity> Get(
            Expression<Func<TEntity, Boolean>> predicate);
        /// <summary>
        /// 更新或插入
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Modify(TEntity entity);
        /// <summary>
        /// 插入
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Insert(TEntity entity);
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Update(TEntity entity);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Delete(TEntity entity);
    }
}

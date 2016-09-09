using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qhyhgf.Orm.ExpressionEx
{
    public class SqlProvider : IQueryProvider
    {
        public IQueryable<TElement> CreateQuery<TElement>(System.Linq.Expressions.Expression expression)
        {
            return new SqlQuery<TElement>(expression);
        }
        public SqlProvider()
        {

        }
        /// <summary>
        /// 创建sql
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public IQueryable CreateQuery(System.Linq.Expressions.Expression expression)
        {
            throw new NotImplementedException();
        }

        public TResult Execute<TResult>(System.Linq.Expressions.Expression expression)
        {


            return default(TResult);
        }

        public object Execute(System.Linq.Expressions.Expression expression)
        {
            return new List<object>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Linq.Expressions;

namespace Qhyhgf.Orm.ExpressionEx
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SqlQuery<T> : IQueryable<T>
    {
        public SqlQuery (System.Linq.Expressions.Expression exp)
        {
            _provider = new SqlProvider();
            _expression = exp;
        }
        Expression2SqlCore<T> _expCore;
        public SqlQuery(Expression2SqlCore<T> exp)
        {
            _expCore = exp;
        }
        public SqlQuery()
        {
            _provider = new SqlProvider();
            _expression = System.Linq.Expressions.Expression.Constant(this);
        }
        public IEnumerator<T> GetEnumerator()
        {
            var result = _provider.Execute<List<T>>(_expression);
            if (result == null)
                yield break;
            foreach (var item in result)
            {
                yield return item;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return (Provider.Execute(Expression) as IEnumerable).GetEnumerator();
        }

        /// <summary>
        /// T类型
        /// </summary>
        public Type ElementType
        {
            get {
                return typeof(T);
            }
        }
        private System.Linq.Expressions.Expression _expression;
        public System.Linq.Expressions.Expression Expression
        {
            get {
                return _expression;
            }
        }
        private IQueryProvider _provider;
        public IQueryProvider Provider
        {
            get {
                return _provider;
            }
        }
    }
}

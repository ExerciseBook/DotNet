using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OrderLibrary
{
    public class OrderQueryBuilder
    {
        private IQueryable<Order> query;


        public OrderQueryBuilder(List<Order> orders)
        {
            this.query = orders.AsQueryable();
        }

        public OrderQueryBuilder Where(string columnName, string searchValue)
        {
            var xType = typeof(Order);
            var x = Expression.Parameter(xType, "x");
            
            var body = Expression.Equal(
                Expression.PropertyOrField(x, columnName),
                Expression.Constant(searchValue)
            );

            query = query.Where(Expression.Lambda<Func<Order, bool>>(body, x));

            return this;
        }

        public OrderQueryBuilder OrderBy(string columnName, bool desc = false)
        {
            string sort = desc ? "desc" : "asc";
            query = query.OrderBy(columnName + " " + sort);
            return this;
        }

        public IEnumerator<Order> Get()
        {
            return query.GetEnumerator();
        }

        
    }
}
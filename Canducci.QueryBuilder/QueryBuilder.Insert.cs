using SqlKata;
using System.Collections.Generic;

namespace Canducci.QueryBuilder
{
    public abstract partial class QueryBuilder
    {
        public QueryBuilder Insert(IEnumerable<string> columns, IEnumerable<object> values)
        {
            query.Insert(columns, values);
            return this;
        }

        public QueryBuilder Insert(Dictionary<string, object> data)
        {
            query.Insert(data);
            return this;
        }

        public QueryBuilder Insert(IEnumerable<string> columns, Query query)
        {
            query.Insert(columns, query);
            return this;
        }
    }
}

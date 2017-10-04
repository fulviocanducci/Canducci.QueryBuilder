using SqlKata;
using System;

namespace Canducci.QueryBuilder
{
    public partial class QueryBuilder
    {
        public QueryBuilder Select(params string[] columns)
        {
            query.Select(columns);
            return this;
        }

        public QueryBuilder SelectRaw(string expression, params object[] bindings)
        {
            query.SelectRaw(expression, bindings);
            return this;
        }

        public QueryBuilder Select(params object[] columns)
        {
            query.Select(columns);
            return this;
        }

        public QueryBuilder Select(Query query, string alias)
        {
            query.Select(query, alias);  
            return this;
        }

        public QueryBuilder Select(Func<Query, Query> callback, string alias)
        {
            query.Select(callback, alias);
            return this;
        }
    }
}

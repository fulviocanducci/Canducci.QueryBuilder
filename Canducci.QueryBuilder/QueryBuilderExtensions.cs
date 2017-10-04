using SqlKata;
using System;

namespace Canducci.QueryBuilder
{
    public static class QueryBuilderExtensions
    {   
        
        public static QueryBuilder ForSqlServer(this QueryBuilder src, Func<Query, Query> fn)
        {
            return src.For("sqlsrv", fn);
        }

        public static QueryBuilder ForPostgres(this QueryBuilder src, Func<Query, Query> fn)
        {
            return src.For("postgres", fn);
        }

        public static QueryBuilder ForMySql(this QueryBuilder src, Func<Query, Query> fn)
        {
            return src.For("mysql", fn);
        }
    }
}

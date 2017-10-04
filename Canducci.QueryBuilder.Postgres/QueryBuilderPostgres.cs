using SqlKata.Compilers;
using System.Data;

namespace Canducci.QueryBuilder.Postgres
{
    public class QueryBuilderPostgres: Canducci.QueryBuilder.QueryBuilder
    {
        public QueryBuilderPostgres(IDbConnection connection)
            :base(connection, new PostgresCompiler())
        {
        }
    }
}

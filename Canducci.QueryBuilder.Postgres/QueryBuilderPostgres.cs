using Canducci.QueryBuilder.Dapper;
using SqlKata.Compilers;
using System.Data;

namespace Canducci.QueryBuilder.Dapper.Postgres
{
    public class QueryBuilderPostgres: QueryBuilderDapper
    {
        public QueryBuilderPostgres(IDbConnection connection)
            :base(connection, new PostgresCompiler())
        {
        }
    }
}

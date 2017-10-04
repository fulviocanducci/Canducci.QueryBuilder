using SqlKata.Compilers;
using System.Data;

namespace Canducci.SQLBuilder.SQLServer
{
    public class QueryBuilderSQLServer: Canducci.QueryBuilder.QueryBuilder
    {
        public QueryBuilderSQLServer(IDbConnection connection)
            :base(connection, new SqlServerCompiler())
        {
        }
    }
}

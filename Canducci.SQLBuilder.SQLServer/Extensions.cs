using Canducci.SQLBuilder.Dapper.SQLServer;
using System.Data;

namespace Canducci.QueryBuilder.Dapper.SQLServer
{
    public static class Extensions
    {
        public static QueryBuilderSQLServer Build(this IDbConnection connection)
            => new QueryBuilderSQLServer(connection);
    }
}

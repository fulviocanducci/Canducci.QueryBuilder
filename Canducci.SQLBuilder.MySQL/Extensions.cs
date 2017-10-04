using Canducci.SQLBuilder.Dapper.MySQL;
using System.Data;
namespace Canducci.QueryBuilder.Dapper.MySQL
{
    public static class Extensions
    {
        public static QueryBuilderMySQL Build(this IDbConnection connection)
            => new QueryBuilderMySQL(connection);
    }
}

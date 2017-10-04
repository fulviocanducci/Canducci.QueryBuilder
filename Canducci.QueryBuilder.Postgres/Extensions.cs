using System.Data;
namespace Canducci.QueryBuilder.Dapper.Postgres
{
    public static class Extensions
    {
        public static QueryBuilderPostgres Build(this IDbConnection connection)
            => new QueryBuilderPostgres(connection);
    }
}

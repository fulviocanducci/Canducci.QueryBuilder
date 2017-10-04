using Canducci.QueryBuilder.Dapper;
using SqlKata.Compilers;
using System.Data;
namespace Canducci.SQLBuilder.Dapper.MySQL
{
    public class QueryBuilderMySQL: QueryBuilderDapper
    {
        public QueryBuilderMySQL(IDbConnection connection)
            :base(connection, new MySqlCompiler())
        {
            
        }
    }
}

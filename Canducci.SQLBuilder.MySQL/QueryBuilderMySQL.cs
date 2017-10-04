using SqlKata.Compilers;
using System.Data;
namespace Canducci.SQLBuilder.MySQL
{
    public class QueryBuilderMySQL: Canducci.QueryBuilder.QueryBuilder
    {
        public QueryBuilderMySQL(IDbConnection connection)
            :base(connection, new MySqlCompiler())
        {
            
        }
    }
}

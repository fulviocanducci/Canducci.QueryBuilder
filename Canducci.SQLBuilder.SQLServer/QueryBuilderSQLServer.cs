using Canducci.QueryBuilder.Dapper;
using SqlKata.Compilers;
using System.Data;

namespace Canducci.SQLBuilder.Dapper.SQLServer
{
    public class QueryBuilderSQLServer: QueryBuilderDapper
    {
        public QueryBuilderSQLServer(IDbConnection connection)
            :base(connection, new SqlServerCompiler())
        {
            
        }
        
    }
}

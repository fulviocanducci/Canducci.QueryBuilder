using Dapper;
using SqlKata;
using SqlKata.Compilers;
using System.Collections.Generic;
using System.Data;

namespace Canducci.QueryBuilder.Dapper
{
    public class QueryBuilderDapper: Canducci.QueryBuilder.QueryBuilder
    {
        public QueryBuilderDapper(IDbConnection connection, Compiler compiler)
            :base(connection, compiler)
        {

        }

        public int Save(IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            SqlResult result = Compiler();
            return connection
                .Execute(result.Sql, result.Bindings, transaction, commandTimeout, commandType);
        }

        public IEnumerable<T> List<T>(IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        {
            SqlResult result = Compiler();
            return connection
                .Query<T>(result.Sql, result.Bindings, transaction, buffered, commandTimeout, commandType);
        }

        public T Find<T>(IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            SqlResult result = Compiler();
            return connection
                .QueryFirst<T>(result.Sql, result.Bindings, transaction, commandTimeout, commandType);
        }
    }
}

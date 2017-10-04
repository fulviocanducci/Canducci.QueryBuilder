using Dapper;
using SqlKata;
using SqlKata.Compilers;
using System.Collections.Generic;
using System.Data;

namespace Canducci.QueryBuilder.Dapper
{
    public class QueryBuilderDapper: QueryBuilder
    {
        public QueryBuilderDapper(IDbConnection connection, Compiler compiler)
            :base(connection, compiler)
        {

        }
        
        public override int SaveOrUpdate()
        {
            SqlResult result = Compiler();
            return connection
                .Execute(result.Sql, result.Bindings);
        }

        public override IEnumerable<T> List<T>()
        {
            SqlResult result = Compiler();
            return connection
                .Query<T>(result.Sql, result.Bindings);
        }

        public override T GetOne<T>()
        {
            SqlResult result = Compiler();
            return connection
                .QueryFirst<T>(result.Sql, result.Bindings);
        }
    }
}

using SqlKata;
using SqlKata.Compilers;
using System.Data;

namespace Canducci.QueryBuilder
{
    public partial class QueryBuilder
    {
        private readonly IDbConnection connection;
        private readonly Query query;
        private readonly Compiler compiler;
        public QueryBuilder(IDbConnection connection, Compiler compiler)
        {
            query = new Query();
            this.compiler = compiler;
            this.connection = connection;

        }
    }
}

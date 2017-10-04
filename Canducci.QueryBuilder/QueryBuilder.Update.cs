using System.Collections.Generic;
namespace Canducci.QueryBuilder
{
    public partial class QueryBuilder
    {
        public QueryBuilder Update(IEnumerable<string> columns, IEnumerable<object> values)
        {
            query.Update(columns, values);
            return this;
        }

        public QueryBuilder Update(Dictionary<string, object> data)
        {
            query.Update(data);
            return this;
        }
    }
}

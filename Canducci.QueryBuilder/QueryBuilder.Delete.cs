namespace Canducci.QueryBuilder
{
    public partial class QueryBuilder
    {
        public QueryBuilder Delete()
        {
            query.Method = "delete";
            return this;
        }
    }
}

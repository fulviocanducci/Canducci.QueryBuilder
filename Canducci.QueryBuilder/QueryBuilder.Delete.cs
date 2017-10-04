namespace Canducci.QueryBuilder
{
    public abstract partial class QueryBuilder
    {
        public QueryBuilder Delete()
        {
            query.Method = "delete";
            return this;
        }
    }
}

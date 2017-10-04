
namespace Canducci.QueryBuilder
{
    public abstract partial class QueryBuilder
    {
        public QueryBuilder Aggregate(string type, params string[] columns)
        {
            query.Aggregate(type, columns);
            return this;
        }

        public QueryBuilder Count(params string[] columns)
        {
            return Aggregate("count", columns);
        }

        public QueryBuilder Avg(string column)
        {
            return Aggregate("avg", column);
        }
        public QueryBuilder Average(string column)
        {
            return Avg(column);
        }

        public QueryBuilder Sum(string column)
        {
            return Aggregate("sum", column);
        }

        public QueryBuilder Max(string column)
        {
            return Aggregate("max", column);
        }

        public QueryBuilder Min(string column)
        {
            return Aggregate("min", column);
        }

    }
}

namespace Canducci.QueryBuilder
{
    public abstract partial class QueryBuilder
    {
        public QueryBuilder Having<T>(string column, string op, T value)
        {
            query.Having(column, op, value);
            return this;
        }

        public QueryBuilder OrHaving(string column, string op, object value)
        {
            query.OrHaving(column, op, value);
            return this;
        }

        public QueryBuilder HavingNot(string column, string op, object value)
        {
            query.HavingNot(column, op, value);
            return this;
        }

        public QueryBuilder OrHavingNot(string column, string op, object value)
        {
            query.OrHavingNot(column, op, value);
            return this;
        }

        public QueryBuilder HavingNull(string column)
        {
            query.HavingNull(column);
            return this;
        }

        public QueryBuilder OrHavingNull(string column)
        {
            query.OrHavingNull(column);
            return this;
        }

        public QueryBuilder HavingNotNull(string column)
        {
            query.HavingNotNull(column);
            return this;
        }

        public QueryBuilder OrHavingNotNull(string column)
        {
            query.OrHavingNotNull(column);
            return this;
        }

        public QueryBuilder HavingRaw(string expression, params object[] bindings)
        {
            query.HavingRaw(expression, bindings);
            return this;
        }

        public QueryBuilder OrHavingRaw(string expression, params object[] bindings)
        {
            query.OrHavingRaw(expression, bindings);
            return this;
        }
    }
}

using SqlKata;
using System;
using System.Collections.Generic;

namespace Canducci.QueryBuilder
{
    public partial class QueryBuilder
    {
        public QueryBuilder Where<T>(string column, string op, T value)
        {
            query.Where(column, op, value);
            return this;
        }
        public QueryBuilder Where<T>(string column, T value)
        {
            return Where(column, "=", value);
        }

        public QueryBuilder Where<T>(Dictionary<string, T> values)
        {
            query.Where(values);
            return this;
        }

        public QueryBuilder Where<T>(IEnumerable<string> columns, IEnumerable<T> values)
        {
            query.Where(columns, values);
            return this;
        }

        public QueryBuilder WhereIf<T>(bool condition, string column, string op, T value)
        {
            query.WhereIf(condition, column, op, value);
            return this;
        }

        public QueryBuilder WhereIf<T>(bool condition, string column, T value)
        {
            return WhereIf(condition, column, "=", value);
        }

        public QueryBuilder OrWhereIf<T>(bool condition, string column, string op, T value)
        {
            query.OrWhereIf(condition, column, op, value);
            return this;
        }

        public QueryBuilder OrWhereIf<T>(bool condition, string column, T value)
        {
            return OrWhereIf(condition, column, "=", value);
        }

        public QueryBuilder WhereRaw(string sql, params object[] bindings)
        {
            query.WhereRaw(sql, bindings);
            return this;
        }

        public QueryBuilder OrWhereRaw(string sql, params object[] bindings)
        {
            query.OrWhereRaw(sql, bindings);
            return this;
        }

        public QueryBuilder Where(Func<Query, Query> callback)
        {
            query.Where(callback);
            return this;
        }

        public QueryBuilder WhereNot(string column, string op, object value)
        {
            query.WhereNot(column, op, value);
            return this;
        }

        public QueryBuilder WhereNot(string column, object value)
        {
            query.WhereNot(column, value);
            return this;
        }

        public QueryBuilder WhereNot(Func<Query, Query> callback)
        {
            query.WhereNot(callback);
            return this;
        }

        public QueryBuilder OrWhere(string column, string op, object value)
        {
            query.OrWhere(column, op, value);
            return this;
        }
        public QueryBuilder OrWhere(string column, object value)
        {
            query.OrWhere(column, value);
            return this;
        }

        public QueryBuilder OrWhere(Func<Query, Query> callback)
        {
            query.OrWhere(callback);
            return this;
        }

        public QueryBuilder OrWhereNot(string column, string op, object value)
        {
            query.OrWhereNot(column, op, value);
            return this;
        }

        public QueryBuilder OrWhereNot(string column, object value)
        {
            query.OrWhereNot(column, value);
            return this;
        }

        public QueryBuilder OrWhereNot(Func<Query, Query> callback)
        {
            query.OrWhereNot(callback);
            return this;
        }

        public QueryBuilder WhereColumns(string first, string op, string second)
        {
            query.WhereColumns(first, op, second);
            return this;
        }

        public QueryBuilder OrWhereColumns(string first, string op, string second)
        {
            query.OrWhereColumns(first, op, second);
            return this;
        }

        public QueryBuilder WhereNull(string column)
        {
            query.WhereNull(column);
            return this;
        }

        public QueryBuilder WhereNotNull(string column)
        {
            query.WhereNotNull(column);
            return this;
        }

        public QueryBuilder OrWhereNull(string column)
        {
            query.OrWhereNull(column);
            return this;
        }

        public QueryBuilder OrWhereNotNull(string column)
        {
            query.OrWhereNotNull(column);
            return this;
        }

        public QueryBuilder WhereLike(string column, string value, bool caseSensitive = false)
        {
            query.WhereLike(column, value, caseSensitive);
            return this;
        }

        public QueryBuilder OrWhereLike(string column, string value, bool caseSensitive = false)
        {
            query.OrWhereLike(column, value, caseSensitive);
            return this;
        }

        public QueryBuilder OrWhereNotLike(string column, string value, bool caseSensitive = false)
        {
            query.OrWhereNotLike(column, value, caseSensitive);
            return this;
        }
        public QueryBuilder WhereStarts(string column, string value, bool caseSensitive = false)
        {
            query.WhereStarts(column, value, caseSensitive);
            return this;
        }

        public QueryBuilder OrWhereStarts(string column, string value, bool caseSensitive = false)
        {
            query.OrWhereStarts(column, value, caseSensitive);
            return this;
        }

        public QueryBuilder OrWhereNotStarts(string column, string value, bool caseSensitive = false)
        {
            query.OrWhereNotStarts(column, value, caseSensitive);
            return this;
        }

        public QueryBuilder WhereEnds(string column, string value, bool caseSensitive = false)
        {
            query.WhereEnds(column, value, caseSensitive);
            return this;
        }

        public QueryBuilder OrWhereEnds(string column, string value, bool caseSensitive = false)
        {
            query.OrWhereEnds(column, value, caseSensitive);
            return this;
        }

        public QueryBuilder OrWhereNotEnds(string column, string value, bool caseSensitive = false)
        {
            query.OrWhereNotEnds(column, value, caseSensitive);
            return this;
        }

        public QueryBuilder WhereContains(string column, string value, bool caseSensitive = false)
        {
            query.WhereContains(column, value, caseSensitive);
            return this;
        }

        public QueryBuilder OrWhereContains(string column, string value, bool caseSensitive = false)
        {
            query.OrWhereContains(column, value, caseSensitive);
            return this;
        }

        public QueryBuilder OrWhereNotContains(string column, string value, bool caseSensitive = false)
        {
            query.OrWhereNotContains(column, value, caseSensitive);
            return this;
        }

        public QueryBuilder WhereBetween<T>(string column, T lower, T higher)
        {
            query.WhereBetween(column, lower, higher);
            return this;
        }

        public QueryBuilder OrWhereBetween<T>(string column, T lower, T higher)
        {
            query.OrWhereBetween(column, lower, higher);
            return this;
        }
        public QueryBuilder WhereNotBetween<T>(string column, T lower, T higher)
        {
            query.WhereNotBetween(column, lower, higher);
            return this;
        }
        public QueryBuilder OrWhereNotBetween<T>(string column, T lower, T higher)
        {
            query.OrWhereNotBetween(column, lower, higher);
            return this;
        }

        public QueryBuilder WhereIn<T>(string column, IEnumerable<T> values)
        {
            query.WhereIn(column, values);
            return this;
        }

        public QueryBuilder OrWhereIn<T>(string column, IEnumerable<T> values)
        {
            query.OrWhereIn(column, values);
            return this;
        }

        public QueryBuilder WhereNotIn<T>(string column, IEnumerable<T> values)
        {
            query.OrWhereIn(column, values);
            return this;
        }

        public QueryBuilder OrWhereNotIn<T>(string column, IEnumerable<T> values)
        {
            query.OrWhereNotIn(column, values);
            return this;
        }


        public QueryBuilder WhereIn(string column, Query query)
        {
            query.WhereIn(column, query);
            return this;
        }
        public QueryBuilder WhereIn(string column, Func<Query, Query> callback)
        {
            query.WhereIn(column, callback);
            return this;
        }

        public QueryBuilder OrWhereIn(string column, Query query)
        {
            query.OrWhereIn(column, query);
            return this;
        }

        public QueryBuilder OrWhereIn(string column, Func<Query, Query> callback)
        {
            query.OrWhereIn(column, callback);
            return this;
        }
        public QueryBuilder WhereNotIn(string column, Query query)
        {
            query.WhereNotIn(column, query);
            return this;
        }

        public QueryBuilder WhereNotIn(string column, Func<Query, Query> callback)
        {
            query.WhereNotIn(column, callback);
            return this;
        }

        public QueryBuilder OrWhereNotIn(string column, Query query)
        {
            query.OrWhereNotIn(column, query);
            return this;
        }

        public QueryBuilder OrWhereNotIn(string column, Func<Query, Query> callback)
        {
            query.OrWhereNotIn(column, callback);
            return this;
        }

        public QueryBuilder Where(string column, string op, Func<Query, Query> callback)
        {
            query.Where(column, op, callback);
            return this;
        }

        public QueryBuilder Where(string column, string op, Query query)
        {
            query.Where(column, op, query);
            return this;
        }

        public QueryBuilder OrWhere(string column, string op, Query query)
        {
            query.OrWhere(column, op, query);
            return this;
        }

        public QueryBuilder OrWhere(string column, string op, Func<Query, Query> callback)
        {
            query.OrWhere(column, op, callback);
            return this;
        }

        public QueryBuilder WhereExists(Query query)
        {
            query.WhereExists(query);
            return this;
        }
        public QueryBuilder WhereExists(Func<Query, Query> callback)
        {
            query.WhereExists(callback);
            return this;
        }

        public QueryBuilder WhereNotExists(Query query)
        {
            query.WhereNotExists(query);
            return this;
        }

        public QueryBuilder WhereNotExists(Func<Query, Query> callback)
        {
            query.WhereNotExists(callback);
            return this;
        }

        public QueryBuilder OrWhereExists(Query query)
        {
            query.OrWhereExists(query);
            return this;
        }
        public QueryBuilder OrWhereExists(Func<Query, Query> callback)
        {
            query.OrWhereExists(callback);
            return this;
        }
        public QueryBuilder OrWhereNotExists(Query query)
        {
            query.OrWhereNotExists(query);
            return this;
        }

        public QueryBuilder OrWhereNotExists(Func<Query, Query> callback)
        {
            query.OrWhereNotExists(callback);
            return this;
        }
    }
}

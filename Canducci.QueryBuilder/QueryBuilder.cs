using SqlKata;
using SqlKata.Compilers;
using System;
using System.Collections.Generic;
using System.Data;

namespace Canducci.QueryBuilder
{
    public partial class QueryBuilder
    {
        protected readonly IDbConnection connection;
        protected readonly Query query;
        protected readonly Compiler compiler;        
        #region Properties
        public List<AbstractClause> Clauses {
            get
            {
                return query.Clauses;
            }
            set
            {
                query.Clauses = value;
            }
        }
        public bool IsDistinct
        {
            get
            {
                return query.IsDistinct;
            }
            set
            {
                query.IsDistinct = value;
            }
        }
        public string Method
        {
            get
            {
                return query.Method;
            }
            set
            {
                query.Method = value;
            }
        }
        public string QueryAlias
        {
            get
            {
                return query.QueryAlias;
            }
            set
            {
                query.QueryAlias = value;
            }
        }
        #endregion Properties

        public QueryBuilder(IDbConnection connection, Compiler compiler)
        {
            query = new Query();
            this.compiler = compiler;
            this.connection = connection;
        }

        public SqlResult Compiler(Query q)
        {
            return compiler.Compile(q);
        }
        public SqlResult Compiler()
        {
            return compiler.Compile(query);
        }

        public static Raw Raw(string value)
        {
            return new Raw(value);
        }

        public QueryBuilder As(string alias)
        {            
            query.QueryAlias = alias;
            return this;
        }

        public QueryBuilder For(string engine, Func<Query, Query> fn)
        {            
            query.For(engine, fn);
            return this;            
        }

        public QueryBuilder With(Query query)
        {
            query.With(query);
            return this;
        }

        public QueryBuilder With(Func<Query, Query> fn)
        {
            return With(fn.Invoke(new Query()));
        }

        public QueryBuilder With(string alias, Query query)
        {
            return With(query.As(alias));
        }

        public QueryBuilder With(string alias, Func<Query, Query> fn)
        {
            return With(alias, fn.Invoke(new Query()));
        }

        public QueryBuilder WithRaw(string alias, string sql, params object[] bindings)
        {
            query.WithRaw(alias, sql, bindings);
            return this;
        }

        public QueryBuilder Limit(int value)
        {
            query.Limit(value);
            return this;
        }

        public QueryBuilder Offset(int value)
        {
            query.Offset(value);
            return this;
        }

        public QueryBuilder Take(int limit)
        {
            query.Take(limit);
            return this;
        }

        public QueryBuilder Skip(int offset)
        {
            return Offset(offset);
        }

        public QueryBuilder ForPage(int page, int perPage = 15)
        {
            query.ForPage(page, perPage);            
            return this;
        }

        public QueryBuilder First()
        {
            return Limit(1);
        }

        public QueryBuilder Distinct()
        {
            IsDistinct = true;            
            return this;
        }
        
        public QueryBuilder When(bool condition, Func<Query, Query> callback)
        {
            query.When(condition, callback);
            return this;
        }
        
        public QueryBuilder WhenNot(bool condition, Func<Query, Query> callback)
        {
            query.WhenNot(condition, callback);
            return this;
        }

        public QueryBuilder OrderBy(string column, bool ascending)
        {
            query.OrderBy(column, ascending);
            return this;
        }

        public QueryBuilder OrderBy(string column, string ordering = "asc")
        {
            return OrderBy(column, ordering.ToLower() == "asc");
        }

        public QueryBuilder OrderByDesc(string column)
        {
            return OrderBy(column, false);
        }

        public QueryBuilder OrderByRaw(string expression, params object[] bindings)
        {
            query.OrderByRaw(expression, bindings);
            return this;
        }

        public QueryBuilder OrderByRandom(string seed)
        {
            return Add("order", new OrderByRandom { });
        }

        public QueryBuilder GroupBy(params string[] columns)
        {
            query.GroupBy(columns);
            return this;
        }

        public QueryBuilder GroupByRaw(string expression, params object[] bindings)
        {
            Add("group", new RawColumn
            {
                Expression = expression,
                Bindings = bindings,
            });

            return this;
        }

        public QueryBuilder GroupBy(Raw expression)
        {
            return GroupByRaw(expression.Value, expression.Bindings);
        }

    }
}

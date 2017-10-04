using SqlKata;
using System;

namespace Canducci.QueryBuilder
{
    public partial class QueryBuilder
    {
        public QueryBuilder DeepJoin(string expression, string sourceKeySuffix = "Id", string targetKey = "Id", string type = "inner" )
        {
            query.DeepJoin(expression, sourceKeySuffix, targetKey, type);
            return this;
        }

        public QueryBuilder DeepJoin(string expression, Func<string, string> sourceKeyGenerator, Func<string, string> targetKeyGenerator = null, string type = "inner")
        {
            query.DeepJoin(expression, sourceKeyGenerator, targetKeyGenerator, type);
            return this;
        }

        public QueryBuilder LeftDeepJoin(string expression,string sourceKeySuffix = "Id", string targetKey = "Id")
        {
            return DeepJoin(expression, sourceKeySuffix, targetKey, "left");
        }

        public QueryBuilder LeftDeepJoin(string expression, Func<string, string> sourceKeyGenerator, Func<string, string> targetKeyGenerator = null)
        {
            return DeepJoin(expression, sourceKeyGenerator, targetKeyGenerator, "left");
        }

        public QueryBuilder RightDeepJoin(string expression, string sourceKeySuffix = "Id", string targetKey = "Id")
        {
            return DeepJoin(expression, sourceKeySuffix, targetKey, "right");
        }

        public QueryBuilder RightDeepJoin(string expression, Func<string, string> sourceKeyGenerator, Func<string, string> targetKeyGenerator = null)
        {
            return DeepJoin(expression, sourceKeyGenerator, targetKeyGenerator, "right");
        }

        public QueryBuilder CrossDeepJoin(string expression,string sourceKeySuffix = "Id", string targetKey = "Id")
        {
            return DeepJoin(expression, sourceKeySuffix, targetKey, "right");
        }

        public QueryBuilder CrossDeepJoin(string expression, Func<string, string> sourceKeyGenerator, Func<string, string> targetKeyGenerator = null)
        {
            return DeepJoin(expression, sourceKeyGenerator, targetKeyGenerator, "cross");
        }

        private QueryBuilder Join(Func<Join, Join> callback)
        {
            var join = callback.Invoke(new Join().AsInner());

            return Add("join", new BaseJoin
            {
                Join = join.SetEngineScope(query.EngineScope)
            });
        }

        public QueryBuilder Join(string table, string first, string second, string op = "=", string type = "inner")
        {
            return Join(j => j.JoinWith(table).WhereColumns(first, op, second).AsType(type));
        }

        public QueryBuilder Join(string table, Func<Join, Join> callback, string type = "inner")
        {
            return Join(j => j.JoinWith(table).Where(callback).AsType(type));
        }

        public QueryBuilder Join(Query query, Func<Join, Join> onCallback, string type = "inner")
        {
            return Join(j => j.JoinWith(query).Where(onCallback).AsType(type));
        }

        public QueryBuilder LeftJoin(string table, string first, string second, string op = "=")
        {
            return Join(table, first, second, op, "left");
        }

        public QueryBuilder LeftJoin(string table, Func<Join, Join> callback)
        {
            return Join(table, callback, "left");
        }

        public QueryBuilder LeftJoin(Query query, Func<Join, Join> onCallback)
        {
            return Join(query, onCallback, "left");
        }

        public QueryBuilder RightJoin(string table, string first, string second, string op = "=")
        {
            return Join(table, first, second, op, "right");
        }

        public QueryBuilder RightJoin(string table, Func<Join, Join> callback)
        {
            return Join(table, callback, "right");
        }

        public QueryBuilder RightJoin(Query query, Func<Join, Join> onCallback)
        {
            return Join(query, onCallback, "right");
        }

        public QueryBuilder CrossJoin(string table)
        {
            return Join(j => j.JoinWith(table).AsCross());
        }
    }
}

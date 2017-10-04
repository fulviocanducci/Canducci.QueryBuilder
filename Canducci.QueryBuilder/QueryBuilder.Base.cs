using SqlKata;
using System;
using System.Collections.Generic;

namespace Canducci.QueryBuilder
{
    public partial class QueryBuilder
    {
        //public string EngineScope = null;
        //private bool orFlag = false;
        //private bool notFlag = false;

        public QueryBuilder SetEngineScope(string engine)
        {            
            query.SetEngineScope(engine);
            return this;
        }

        public virtual List<AbstractClause> OrderedClauses(string engine)
        {            
            return query.OrderedClauses(engine);
        }

        public virtual List<object> GetBindings(string engine)
        {
            return query.GetBindings(engine);
        }

        public virtual Query Clone()
        {
            return query.Clone();
        }

        public Query SetParent(AbstractQuery parent)
        {
            return query.SetParent(parent);
        }

        public Query NewQuery()
        {
            return query.NewQuery();
        }

        public Query NewChild()
        {
            return query.NewChild();
        }
        
        public QueryBuilder Add(string component, AbstractClause clause, string engineCode = null)
        {
            query.Add(component, clause, engineCode);
            return this;
        }

        public List<C> Get<C>(string component, string engineCode = null) where C : AbstractClause
        {
            return query.Get<C>(component, engineCode);
        }

        public List<AbstractClause> Get(string component, string engineCode = null)
        {            
            return query.Get(component, engineCode);
        }

        public C GetOne<C>(string component, string engineCode = null) where C : AbstractClause
        {            
            return query.GetOne<C>(component, engineCode);
        }

        public AbstractClause GetOne(string component, string engineCode = null)
        {
            return query.GetOne(component, engineCode);
        }

        public bool Has(string component, string engineCode = null)
        {
            return query.Has(component, engineCode);
        }

        public QueryBuilder Clear(string component, string engineCode = null)
        {
            query.Clear(component, engineCode);
            return this;
        }

       
        //protected QueryBuilder And()
        //{
        //    orFlag = false;
        //    return this;
        //}

        //protected QueryBuilder Or()
        //{
        //     orFlag = true;
        //    return (Q)this;
        //} 
        
        //protected QueryBuilder Not(bool flag)
        //{
        //    notFlag = flag;
        //    return (Q)this;
        //}

        //protected bool getOr()
        //{
        //    var ret = orFlag;

        //    // reset the flag
        //    orFlag = false;
        //    return ret;
        //}

        //protected bool getNot()
        //{
        //    var ret = notFlag;

        //    // reset the flag
        //    notFlag = false;
        //    return ret;
        //}

        public QueryBuilder From(string table)
        {
            query.From(table);
            return this;
        }

        public QueryBuilder From(Query query, string alias = null)
        {
            query.From(query, alias);
            return this;
        }

        public QueryBuilder FromRaw(string expression, params object[] bindings)
        {
            query.FromRaw(expression, bindings);
            return this;
        }

        public QueryBuilder From(Raw expression)
        {
            query.From(expression);
            return this;
        }

        public QueryBuilder From(Func<Query, Query> callback, string alias = null)
        {
            query.From(callback, alias);
            return this;
        }
    }
}

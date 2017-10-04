using System.Collections.Generic;
namespace Canducci.QueryBuilder
{
    public abstract partial class QueryBuilder
	{
        public abstract int SaveOrUpdate();
        public abstract IEnumerable<T> List<T>();
        public abstract T GetOne<T>();
    }
}

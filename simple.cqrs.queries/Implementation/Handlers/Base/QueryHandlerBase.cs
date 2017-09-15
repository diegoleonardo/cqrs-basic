using simple.cqrs.queries.Base;
using simple.cqrs.queries.Interfaces;
using System;

namespace simple.cqrs.queries.Implementation.Handlers.Base
{
    public class QueryHandlerBase<T> where T : QueryParameter, IQueryHandler<IQueryResult, IQuery>
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IQueryResult Retrieve(IQuery query)
        {
            throw new NotImplementedException();
        }

        public virtual IQueryResult Retrieve(T query)
        {
            return Retrieve(query);
        }
    }
}

using simple.cqrs.queries.Interfaces;

namespace simple.cqrs.queries.Implementation
{
    public class QueryDispatcher : IQueryDispatcher
    {
        public TResult Dispatch<TResult, TParameter>(TParameter query)
            where TParameter : IQuery
            where TResult : IQueryResult
        {
            var queryHandler = FactoryQueryHandler.GetQueryHandler(query);

            return (TResult) queryHandler.Retrieve(query);
        }
    }
}

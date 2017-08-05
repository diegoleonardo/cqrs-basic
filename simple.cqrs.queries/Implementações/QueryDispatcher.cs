using simple.cqrs.queries.Interfaces;

namespace simple.cqrs.queries.Implementações
{
    public class QueryDispatcher : IQueryDispatcher
    {
        private readonly QueryHandler _queryHandler;
        public QueryDispatcher()
        {
            _queryHandler = new QueryHandler();
        }

        public TResult Dispatch<TParameter, TResult>(TParameter query)
            where TParameter : IQuery
            where TResult : IQueryResult
        {
            throw new System.NotImplementedException();
        }
    }
}

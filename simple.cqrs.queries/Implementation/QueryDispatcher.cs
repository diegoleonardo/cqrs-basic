using simple.cqrs.queries.Interfaces;

namespace simple.cqrs.queries.Implementation
{
    public class QueryDispatcher : IQueryDispatcher
    {
        private readonly QueryHandler _queryHandler;
        public QueryDispatcher()
        {
            _queryHandler = new QueryHandler();
        }

        public IQueryResult Dispatch<TParameter>(TParameter query)
            where TParameter : IQuery
        {
            var retrieve =  _queryHandler.Retrieve(query);
            return retrieve;
        }
    }
}

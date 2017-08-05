using simple.cqrs.queries.Interfaces;

namespace simple.cqrs.queries.Implementation
{
    public class QueryHandler : IQueryHandler<Query, QueryResult>
    {
        public QueryResult Retrieve(Query query)
        {
            throw new System.NotImplementedException();
        }
    }
}

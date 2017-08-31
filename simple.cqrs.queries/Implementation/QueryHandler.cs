using simple.cqrs.queries.Interfaces;

namespace simple.cqrs.queries.Implementation
{
    public class QueryHandler : IQueryHandler<IQuery, QueryResult>
    {
        public QueryResult Retrieve(IQuery query)
        {
            return new QueryResult();
        }
    }
}

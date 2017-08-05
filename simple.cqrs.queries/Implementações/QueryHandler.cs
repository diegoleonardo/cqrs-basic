using simple.cqrs.queries.Interfaces;

namespace simple.cqrs.queries.Implementações
{
    public class QueryHandler : IQueryHandler<Query, QueryResult>
    {
        public QueryResult Retrieve(Query query)
        {
            throw new System.NotImplementedException();
        }
    }
}

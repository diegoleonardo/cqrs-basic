using cqrs.example.queries.Interfaces;

namespace cqrs.example.queries.Implementações
{
    public class QueryHandler : IQueryHandler<Query, Result>
    {
        public Result Retrieve(Query query)
        {
            throw new System.NotImplementedException();
        }
    }
}

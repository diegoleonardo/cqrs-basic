using simple_cqrs.queries.Interfaces;

namespace simple_cqrs.queries.Implementações
{
    public class QueryHandler : IQueryHandler<Query, Result>
    {
        public Result Retrieve(Query query)
        {
            throw new System.NotImplementedException();
        }
    }
}

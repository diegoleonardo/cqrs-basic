using simple.cqrs.queries.Interfaces;

namespace simple.cqrs.queries.Implementation
{
    public class Query : IQuery
    {
        public string Identificador { get; set; }
    }
}

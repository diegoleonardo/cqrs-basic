using simple.cqrs.queries.Interfaces;

namespace simple.cqrs.queries.Base
{
    public class QueryParameter: IQuery
    {
        public string Identifier { get; set; }
    }
}

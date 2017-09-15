using simple.cqrs.queries.Interfaces;

namespace simple.cqrs.queries.Implementation
{
    public class FindPersonByIdQueryParameter: IQuery
    {
        public FindPersonByIdQueryParameter(string identifier)
        {
            Identifier = identifier;
        }

        public string Identifier{ get; set; }
    }
}

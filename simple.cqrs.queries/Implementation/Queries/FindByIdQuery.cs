using simple.cqrs.queries.Base;

namespace simple.cqrs.queries.Implementation
{
    public class FindPersonByIdQueryParameter: QueryParameter
    {
        public FindPersonByIdQueryParameter(string identificador)
        {
            Identifier = identificador;
        }
    }
}

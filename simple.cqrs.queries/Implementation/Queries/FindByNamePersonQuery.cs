using simple.cqrs.queries.Interfaces;

namespace simple.cqrs.queries.Implementation
{
    public class FindPersonByNameParameter : IQuery
    {
        public string Name { get; private set; }

        public string Identifier
        {
            get; set;
        }

        public FindPersonByNameParameter(string name)
        {
            Name = name;
        }
    }
}

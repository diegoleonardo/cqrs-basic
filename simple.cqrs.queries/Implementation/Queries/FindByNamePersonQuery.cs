using simple.cqrs.queries.Base;

namespace simple.cqrs.queries.Implementation
{
    public class FindPersonByNameParameter : QueryParameter
    {
        public string Name { get; private set; }

        public FindPersonByNameParameter (string name)
        {
            Name = name;
        }
    }
}

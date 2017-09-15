using System;
using simple.cqrs.queries.Interfaces;

namespace simple.cqrs.queries.Implementation.Queries
{
    public class FindAllPersonsParam : IQuery
    {
        public string Identifier { get; set; }
    }
}

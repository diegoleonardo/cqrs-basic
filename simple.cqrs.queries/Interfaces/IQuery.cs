using System;

namespace simple.cqrs.queries.Interfaces
{
    public interface IQuery
    {
        string Identifier { get; set; }
    }
}

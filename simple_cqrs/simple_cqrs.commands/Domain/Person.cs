using simple_cqrs.commands.EventSources;
using System;

namespace simple_cqrs.commands.Domain
{
    public class Person : AggregateRoot
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }

        public Person(Guid personId, string firstname, string lastname, DateTime birthdate)
        {
            Apply(new PersonCreatedEvent(Guid.NewGuid(), firstname, lastname, birthdate));
        }
    }
}

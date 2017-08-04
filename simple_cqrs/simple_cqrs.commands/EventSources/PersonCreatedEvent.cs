using System;

namespace simple_cqrs.commands.EventSources
{
    public class PersonCreatedEvent : DomainEvent
    {
        public Guid PersonId
        {
            get { return AggregateRootId; }
            set { AggregateRootId = value; }
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }

        public PersonCreatedEvent(Guid personId, string firstname, string lastname, DateTime birthdate)
        {
            PersonId = personId;
            Firstname = firstname;
            Lastname = lastname;
            Birthdate = birthdate;
        }
    }
}

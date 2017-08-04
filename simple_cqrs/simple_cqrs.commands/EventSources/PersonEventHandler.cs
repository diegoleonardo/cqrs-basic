using System;

namespace simple_cqrs.commands.EventSources
{
    public class PersonEventHandler : IHandleDomainEvents<PersonCreatedEvent>
    {
        public void Handle(PersonCreatedEvent domainEvent)
        {
            throw new NotImplementedException();
        }
    }
}

using System.Collections.Generic;

namespace simple_cqrs.commands.EventSources
{
    public interface IEventBus
    {
        void PublishEvent(DomainEvent domainEvent);
        void PublishEvents(IEnumerable<DomainEvent> domainEvents);
    }
}

using System;

namespace simple_cqrs.commands.EventSources
{
    [Serializable]
    public class EntityDomainEvent : DomainEvent
    {
        public Guid EntityId { get; set; }
    }
}

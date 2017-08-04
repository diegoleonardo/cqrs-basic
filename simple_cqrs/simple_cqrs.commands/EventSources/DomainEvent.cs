using System;

namespace simple_cqrs.commands.EventSources
{
    [Serializable]
    public class DomainEvent
    {
        public Guid AggregateRootId { get; set; }
        public int Sequence { get; set; }
        public DateTime EventDate { get; set; }
    }
}

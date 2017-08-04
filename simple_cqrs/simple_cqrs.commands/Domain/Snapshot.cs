using System;

namespace simple_cqrs.commands.Domain
{
    public class Snapshot
    {
        public Guid AggregateRootId { get; set; }
        public int LastEventSequence { get; set; }
    }
}

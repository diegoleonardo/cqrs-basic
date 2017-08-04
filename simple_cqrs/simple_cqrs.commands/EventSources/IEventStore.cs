﻿using System;
using System.Collections.Generic;

namespace simple_cqrs.commands.EventSources
{
    public interface IEventStore
    {
        IEnumerable<DomainEvent> GetEvents(Guid aggregateRootId, int startSequence);
        void Insert(IEnumerable<DomainEvent> domainEvents);
        IEnumerable<DomainEvent> GetEventsByEventTypes(IEnumerable<Type> domainEventTypes);
        IEnumerable<DomainEvent> GetEventsByEventTypes(IEnumerable<Type> domainEventTypes, Guid aggregateRootId);
        IEnumerable<DomainEvent> GetEventsByEventTypes(IEnumerable<Type> domainEventTypes, DateTime startDate, DateTime endDate);
    }
}

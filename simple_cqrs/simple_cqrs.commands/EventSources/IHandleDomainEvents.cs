namespace simple_cqrs.commands.EventSources
{
    public interface IHandleDomainEvents<in TDomainEvent> where TDomainEvent : DomainEvent
    {
        void Handle(TDomainEvent domainEvent);
    }
}

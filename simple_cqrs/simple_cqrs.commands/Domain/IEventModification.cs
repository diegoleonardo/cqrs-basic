using simple_cqrs.commands.EventSources;

namespace simple_cqrs.commands.Domain
{
    public interface IEventModification
    {
        void Apply(DomainEvent e);
    }
}

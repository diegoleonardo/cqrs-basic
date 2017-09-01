using simple.cqrs.commands.Implementation;

namespace simple.cqrs.commands.Interfaces
{
    public interface ICommandHandler
    {
        CommandResult Execute(ICommand command);
    }
}

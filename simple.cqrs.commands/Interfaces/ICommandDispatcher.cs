using simple.cqrs.commands.Implementation;

namespace simple.cqrs.commands.Interfaces
{
    public interface ICommandDispatcher
    {
        CommandResult Dispatch<TParameter>(TParameter command) where TParameter : ICommand;
    }
}

using simple.cqrs.commands.Implementation.FactoryHandlers;
using simple.cqrs.commands.Interfaces;

namespace simple.cqrs.commands.Implementation
{
    public class CommandDispatcher : ICommandDispatcher
    {
        public CommandResult Dispatch<TParameter>(TParameter command) where TParameter : ICommand
        {
            var handler = FactoryCommandHandler.GetCommandHandler(command);
            return handler.Execute<TParameter>(command);
        }
    }
}

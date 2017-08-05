using simple.cqrs.commands.Implementações;

namespace simple.cqrs.commands.Interfaces
{
    public interface ICommandHandler<in TParameter> where TParameter : ICommand
    {
        CommandResult Execute(TParameter command);
    }
}

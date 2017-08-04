using simple_cqrs.commands.Implementações;

namespace simple_cqrs.commands.Interfaces
{
    public interface ICommandHandler<in TParameter> where TParameter : ICommand
    {
        CommandResult Execute(TParameter command);
    }
}

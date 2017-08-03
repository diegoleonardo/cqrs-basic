using cqrs.example.commands.Implementações;

namespace cqrs.example.commands.Interfaces
{
    public interface ICommandHandler<in TParameter> where TParameter: ICommand
    {
        CommandResult Execute(TParameter command);
    }
}

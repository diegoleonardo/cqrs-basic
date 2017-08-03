using cqrs.example.commands.Interfaces;

namespace cqrs.example.commands.Implementações
{
    public class InsertPersonCommandHandler : ICommandHandler<InsertPersonCommand>
    {
        public CommandResult Execute(InsertPersonCommand command)
        {
            return new CommandResult()
            {
                Success = true,
                Message = "Success"
            };
        }
    }
}

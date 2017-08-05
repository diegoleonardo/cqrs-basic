using simple.cqrs.commands.Interfaces;

namespace simple.cqrs.commands.Implementações.Logs
{
    public class LogPersonCommandHandler : ICommandHandler<LogPersonCommand>
    {
        public CommandResult Execute(LogPersonCommand command)
        {
            return new CommandResult()
            {
                Message = "Success",
                Success = true
            };
        }
    }
}

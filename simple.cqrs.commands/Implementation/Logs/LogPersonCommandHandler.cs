using simple.cqrs.commands.Interfaces;

namespace simple.cqrs.commands.Implementation.Logs
{
    public class LogPersonCommandHandler : ICommandHandler
    {
        public CommandResult Execute(ICommand command)
        {
            return new CommandResult()
            {
                Message = "Success",
                Success = true
            };
        }
    }
}

using simple.cqrs.commands.Interfaces;

namespace simple.cqrs.commands.Implementation.Histories
{
    public class HistoricalPersonCommandHandler : ICommandHandler
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

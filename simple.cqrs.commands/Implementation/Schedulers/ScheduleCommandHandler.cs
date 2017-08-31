using simple.cqrs.commands.Interfaces;

namespace simple.cqrs.commands.Implementation.Schedulers
{
    public class ScheduleCommandHandler : ICommandHandler
    {
        public CommandResult Execute<TParameter>(TParameter command) where TParameter : ICommand
        {
            return new CommandResult()
            {
                Message = "Success",
                Success = true,
                Data = command
            };
        }
    }
}

using simple.cqrs.commands.Interfaces;

namespace simple.cqrs.commands.Implementações.Schedulers
{
    public class ScheduleCommandHandler : ICommandHandler<InsertSchedulerCommand>
    {
        public CommandResult Execute(InsertSchedulerCommand command)
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

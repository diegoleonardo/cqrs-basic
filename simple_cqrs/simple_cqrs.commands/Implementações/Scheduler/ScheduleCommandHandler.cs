using simple_cqrs.commands.Interfaces;

namespace simple_cqrs.commands.Implementações.Scheduler
{
    public class ScheduleCommandHandler : ICommandHandler<ScheduleCommand>
    {
        public CommandResult Execute(ScheduleCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}

using Ninject.Modules;
using simple.cqrs.commands.Implementation.Schedulers;
using simple.cqrs.commands.Interfaces;

namespace simple.cqrs.applicationService.CommandModules.Scheduler
{
    public class SchedulerModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICommand>().To<InsertSchedulerCommand>();
            Bind<ICommandHandler<InsertSchedulerCommand>>().To<ScheduleCommandHandler>();
        }
    }
}

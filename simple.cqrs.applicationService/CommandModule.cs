using Ninject;
using Ninject.Modules;
using simple.cqrs.commands.Implementações;
using simple.cqrs.commands.Implementações.Histories;
using simple.cqrs.commands.Implementações.Logs;
using simple.cqrs.commands.Implementações.Persons;
using simple.cqrs.commands.Implementações.Schedulers;
using simple.cqrs.commands.Interfaces;

namespace simple.cqrs.applicationService
{
    public class CommandModule : NinjectModule
    {
        public override void Load()
        {
            var kernel = new StandardKernel();

            Bind<ICommandDispatcher>().To<CommandDispatcher>();
            Bind<ICommand>().To<InsertPersonCommand>();
            Bind<ICommandHandler<InsertPersonCommand>>().To<InsertPersonCommandHandler>();
            Bind<ICommandHandler<EditPersonCommand>>().To<EditPersonCommandHandler>();
            
            Bind<ICommand>().To<InsertSchedulerCommand>();
            Bind<ICommandHandler<InsertSchedulerCommand>>().To<ScheduleCommandHandler>();

            Bind<ICommand>().To<InsertPersonHistoryCommand>();
            Bind<ICommandHandler<InsertPersonHistoryCommand>>().To<InsertPersonHistoryCommandHandler>();

            Bind<ICommand>().To<LogPersonCommand>();
            Bind<ICommandHandler<LogPersonCommand>>().To<LogPersonCommandHandler>();
        }
    }
}

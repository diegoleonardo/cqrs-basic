using Ninject.Modules;
using simple.cqrs.commands.Implementation.Logs;
using simple.cqrs.commands.Interfaces;

namespace simple.cqrs.applicationService.CommandModules.Log
{
    public class LogModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICommand>().To<LogPersonCommand>();
            Bind<ICommandHandler<LogPersonCommand>>().To<LogPersonCommandHandler>();
        }
    }
}

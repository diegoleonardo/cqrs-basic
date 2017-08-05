using Ninject.Modules;
using simple.cqrs.commands.Implementation;
using simple.cqrs.commands.Interfaces;

namespace simple.cqrs.applicationService.Dispatcher.CommandModules
{
    public class DispatcherModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICommandDispatcher>().To<CommandDispatcher>();
        }
    }
}

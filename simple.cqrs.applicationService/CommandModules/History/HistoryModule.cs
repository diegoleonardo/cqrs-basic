using Ninject.Modules;
using simple.cqrs.commands.Implementation.Histories;
using simple.cqrs.commands.Interfaces;

namespace simple.cqrs.applicationService.CommandModules.History
{
    public class HistoryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICommand>().To<InsertPersonHistoryCommand>();
            Bind<ICommandHandler<InsertPersonHistoryCommand>>().To<InsertPersonHistoryCommandHandler>();
        }
    }
}

using Ninject.Modules;
using simple.cqrs.commands.Implementation.Persons;
using simple.cqrs.commands.Interfaces;

namespace simple.cqrs.applicationService.CommandModules.Person
{
    public class PersonModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICommand>().To<InsertPersonCommand>();
            Bind<ICommandHandler<InsertPersonCommand>>().To<InsertPersonCommandHandler>();
            Bind<ICommandHandler<EditPersonCommand>>().To<EditPersonCommandHandler>();
        }
    }
}

using Ninject.Modules;
using simple.cqrs.commands.Implementation.Persons;
using simple.cqrs.commands.Interfaces;
using simple.cqrs.queries.Interfaces;
using simple.cqrs.queries.Implementation;
using simple.cqrs.commands.Implementation.Histories;
using simple.cqrs.commands.Implementation.Logs;
using simple.cqrs.commands.Implementation;
using simple.cqrs.applicationService.Services;
using Ninject;
using simple.cqrs.queries.Base;

namespace simple.cqrs.dependencyInjection
{
    public class ContainerPrincipal:NinjectModule
    {
        public IKernel _kernel { get; set;}
        public override void Load()
        {
             _kernel = new StandardKernel();
            
            _kernel.Bind<IQuery>().To<QueryParameter>();
            _kernel.Bind<IQueryResult>().To<FindByIdQueryResult>();
            _kernel.Bind<IQueryHandler<IQueryResult, IQuery>>().To<PersonQueryHandler>();
            _kernel.Bind<IQueryDispatcher>().To<QueryDispatcher>();

            //_kernel.Bind<ICommandHandler<HistoricalPersonCommand>>().To<HistoricalPersonCommandHandler>();
            //_kernel.Bind<ICommandHandler<InsertPersonCommand>>().To<InsertPersonCommandHandler>();
            //_kernel.Bind<ICommandHandler<EditPersonCommand>>().To<EditPersonCommandHandler>();
            //_kernel.Bind<ICommandHandler<LogPersonCommand>>().To<LogPersonCommandHandler>();

            _kernel.Bind<ICommandDispatcher>().To<CommandDispatcher>();

            _kernel.Bind<IPersonAplicationService>().To<PersonApplicationService>();
        }

        public IKernel RetornaKernel()
        {
            return _kernel;
        }
    }
}

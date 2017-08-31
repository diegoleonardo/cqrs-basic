using simple.cqrs.applicationService.Services;
using simple.cqrs.commands.Implementation;
using simple.cqrs.commands.Implementation.Histories;
using simple.cqrs.commands.Implementation.Logs;
using simple.cqrs.commands.Implementation.Persons;
using simple.cqrs.commands.Interfaces;
using simple.cqrs.queries.Implementation;
using simple.cqrs.queries.Interfaces;
using SimpleInjector;
using SimpleInjector.Integration.Web;

namespace simple.cqrs.dependencyInjection
{
    public static class SimpleInjectionContainer
    {
        public static Container Container { get; private set; }
        public static Container RegisterServices()
        {
            Container = new Container();
            Container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            var lifeStyle = Lifestyle.Scoped;

            //Container.Register<ICommandHandler<InsertPersonCommand>, InsertPersonCommandHandler>(lifeStyle);
            //Container.Register<ICommandHandler<EditPersonCommand>, EditPersonCommandHandler>(lifeStyle);

            Container.Register<IQuery, Query>(lifeStyle);
            Container.Register<IQueryResult, QueryResult>(lifeStyle);
            Container.Register<IQueryHandler<IQuery, QueryResult>, QueryHandler>(lifeStyle);
            Container.Register<IQueryDispatcher, QueryDispatcher>(lifeStyle);

            //Container.Register<ICommandHandler<HistoricalPersonCommand>, HistoricalPersonCommandHandler>(lifeStyle);

            //Container.Register<ICommandHandler<LogPersonCommand>, LogPersonCommandHandler>(lifeStyle);

            Container.Register<ICommandDispatcher, CommandDispatcher>(lifeStyle);
            Container.Register<IPersonAplicationService, PersonApplicationService>(lifeStyle);

            return Container;
        }
    }
}

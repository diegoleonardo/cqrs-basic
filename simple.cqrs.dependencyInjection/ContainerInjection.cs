using Autofac;
using simple.cqrs.applicationService.Services;
using simple.cqrs.commands.Implementation;
using simple.cqrs.commands.Implementation.Histories;
using simple.cqrs.commands.Implementation.Logs;
using simple.cqrs.commands.Implementation.Persons;
using simple.cqrs.commands.Interfaces;
using simple.cqrs.queries.Implementation;
using simple.cqrs.queries.Interfaces;

namespace simple.cqrs.dependencyInjection
{
    public static class ContainerInjectionPerson
    {
        public static IContainer Container;
        public static void Load()
        {
            // Create your builder.
            var builder = new ContainerBuilder();

            // Usually you're only interested in exposing the type
            // via its interface:

            builder.RegisterType<InsertPersonCommandHandler>().As<ICommandHandler>();
            builder.RegisterType<EditPersonCommandHandler>().As<ICommandHandler>();


            builder.RegisterType<Query>().As<IQuery>();
            builder.RegisterType<QueryResult>().As<IQueryResult>();

            builder.RegisterType<QueryHandler>().As<IQueryHandler<Query, QueryResult>>();

            builder.RegisterType<QueryDispatcher>().As<IQueryDispatcher>();

            builder.RegisterType<HistoricalPersonCommand>().As<ICommand>();
            builder.RegisterType<HistoricalPersonCommandHandler>().As<ICommandHandler>();

            builder.RegisterType<LogPersonCommand>().As<ICommand>();
            builder.RegisterType<LogPersonCommandHandler>().As<ICommandHandler>();

            builder.RegisterType<CommandDispatcher>().As<ICommandDispatcher>();

            builder.RegisterType<PersonApplicationService>().As<IPersonAplicationService>();

            // However, if you want BOTH services (not as common)
            // you can say so:
            //builder.RegisterType<SomeType>().AsSelf().As<IService>();
            Container = builder.Build();
        }
    }
}

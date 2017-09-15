using simple.cqrs.queries.Implementation;
using simple.cqrs.queries.Implementation.Handlers;
using simple.cqrs.queries.Implementation.Queries;
using simple.cqrs.queries.Implementation.QueryResults;
using simple.cqrs.queries.Interfaces;
using SimpleInjector;
using SimpleInjector.Lifestyles;

namespace simple.cqrs.queries.Containers
{
    public static class HandlersInjectionContainer
    {
        public static Container ContainerQueryHandlers { get; private set; }
        public static Container RegisterServices()
        {
            ContainerQueryHandlers = new Container();

            ContainerQueryHandlers.Options.DefaultScopedLifestyle = new ThreadScopedLifestyle();

            var lifeStyle = Lifestyle.Scoped;
           
            ContainerQueryHandlers.Register<IQueryHandler<FindByNamePersonQueryResult, FindPersonByNameParameter>, FindByNameQueryHandler>(lifeStyle);
            ContainerQueryHandlers.Register<IQueryHandler<FindByIdQueryResult, FindPersonByIdQueryParameter>, PersonQueryHandler>(lifeStyle);
            ContainerQueryHandlers.Register<IQueryHandler<FindAllPersonsQueryResult, FindAllPersonsParam>, FindAllPersonsQueryHandler>(lifeStyle);

            return ContainerQueryHandlers;
        }

        public static bool ContainerWasRegistered()
        {
            return ContainerQueryHandlers != null && !ContainerQueryHandlers.IsVerifying;
        }

        public static T RecuperaInstancia<T>() where T : class
        {
            return ContainerQueryHandlers.GetInstance<T>();
        }
    }
}

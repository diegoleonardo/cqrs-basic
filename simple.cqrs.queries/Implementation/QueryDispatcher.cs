using simple.cqrs.queries.Interfaces;
using simple.cqrs.queries.Containers;
using SimpleInjector.Lifestyles;

namespace simple.cqrs.queries.Implementation
{
    public class QueryDispatcher : IQueryDispatcher
    {
        public QueryDispatcher()
        {
            if (!HandlersInjectionContainer.ContainerWasRegistered())
            {
                var container = HandlersInjectionContainer.RegisterServices();
                container.Verify();
            }
        }

        public TResult Dispatch<TResult, TParameter>(TParameter query)
            where TParameter : IQuery
            where TResult : IQueryResult
        {
            using (ThreadScopedLifestyle.BeginScope(HandlersInjectionContainer.ContainerQueryHandlers))
            {
                using (var queryHandler = HandlersInjectionContainer.RecuperaInstancia<IQueryHandler<TResult, TParameter>>())
                {
                    return queryHandler.Retrieve(query);
                }
            }
        }
    }
}

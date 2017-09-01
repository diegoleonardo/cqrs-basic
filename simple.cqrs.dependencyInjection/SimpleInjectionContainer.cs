using simple.cqrs.applicationService.Services;
using simple.cqrs.commands.Implementation;
using simple.cqrs.commands.Interfaces;
using simple.cqrs.queries.Base;
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

            Container.Register<IQuery, QueryParameter>(lifeStyle);
            Container.Register<IQueryHandler<IQueryResult, IQuery>, PersonQueryHandler>(lifeStyle);
            Container.Register<IQueryDispatcher, QueryDispatcher>(lifeStyle);

            Container.Register<ICommandDispatcher, CommandDispatcher>(lifeStyle);
            Container.Register<IPersonAplicationService, PersonApplicationService>(lifeStyle);

            return Container;
        }
    }
}

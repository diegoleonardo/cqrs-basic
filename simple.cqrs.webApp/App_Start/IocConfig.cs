using simple.cqrs.dependencyInjection;
using SimpleInjector;

namespace simple.cqrs.webApp.App_Start
{
    public static class IocConfig
    {
        public static Container Container { get; set; }
        public static Container InicializarContainer()
        {
            Container = SimpleInjectionContainer.RegisterServices();
            return Container;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace simple.cqrs.webApp.App_Start
{
    public class CustomAutofacDependencyResolver : IDependencyResolver, IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public object GetService(Type serviceType)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            throw new NotImplementedException();
        }
    }
}
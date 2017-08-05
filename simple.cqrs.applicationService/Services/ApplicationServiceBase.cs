using Ninject;
using Ninject.Modules;
using simple.cqrs.applicationService.Dispatcher.CommandModules;
using simple.cqrs.commands.Interfaces;
using System;
using System.Collections.Generic;

namespace simple.cqrs.applicationService.Services
{
    public class ApplicationServiceBase : IDisposable
    {
        protected bool disposed = false;
        protected readonly ICommandDispatcher CommandDispatcher;
        protected readonly IKernel Kernel;
        protected IList<NinjectModule> Modules;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
                disposed = true;
        }

        public ApplicationServiceBase()
        {
            Kernel = new StandardKernel(new DispatcherModule());
            CommandDispatcher = Kernel.Get<ICommandDispatcher>();
            Modules = new List<NinjectModule>();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

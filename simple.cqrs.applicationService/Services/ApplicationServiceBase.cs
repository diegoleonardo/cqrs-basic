using simple.cqrs.commands.Interfaces;
using System;

namespace simple.cqrs.applicationService.Services
{
    public class ApplicationServiceBase : IDisposable
    {
        protected bool disposed = false;
        public ICommandDispatcher CommandDispatcher;
        public ApplicationServiceBase(ICommandDispatcher commandDispatcher)
        {
            CommandDispatcher = commandDispatcher;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
                disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

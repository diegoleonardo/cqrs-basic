using Ninject;
using simple.cqrs.commands.Interfaces;
using System;

namespace simple.cqrs.commands.Implementation
{
    public class CommandDispatcher : ICommandDispatcher
    {
        private readonly IKernel _kernel;

        public CommandDispatcher(IKernel kernel)
        {
            if (kernel == null)
            {
                throw new ArgumentNullException("kernel");
            }

            _kernel = kernel;
        }

        public CommandResult Dispatch<TParameter>(TParameter command) where TParameter : ICommand
        {
            // Find the appropriate handler to call from those registered with Ninject based on the type parameters  
            var handler = _kernel.Get<ICommandHandler<TParameter>>();
            return handler.Execute(command);
        }
    }
}

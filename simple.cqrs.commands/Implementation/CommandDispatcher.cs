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
            var handler = _kernel.Get<ICommandHandler<TParameter>>();
            return handler.Execute(command);
        }

        public CommandResult Dispatch<TParameter>(ICommandHandler<TParameter> commandHandler, TParameter command) where TParameter : ICommand
        {
            return commandHandler.Execute(command);
        }
    }
}

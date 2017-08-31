using System;
using simple.cqrs.commands.Interfaces;

namespace simple.cqrs.commands.Implementation.Address
{
    public class InsertAddressCommandHandler : ICommandHandler
    {
        public CommandResult Execute(InsertAddressCommand command)
        {
            return new CommandResult()
            {
                Success = true,
                Message = "Success"
            };
        }

        public CommandResult Execute<TParameter>(TParameter command) where TParameter : ICommand
        {
            return new CommandResult()
            {
                Success = true,
                Message = "Success"
            };
        }
    }
}

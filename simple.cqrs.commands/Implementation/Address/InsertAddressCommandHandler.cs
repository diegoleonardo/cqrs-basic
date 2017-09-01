using System;
using simple.cqrs.commands.Interfaces;

namespace simple.cqrs.commands.Implementation.Address
{
    public class InsertAddressCommandHandler : ICommandHandler
    {
        public CommandResult Execute(ICommand command)
        {
            return new CommandResult()
            {
                Success = true,
                Message = "Success"
            };
        }
    }
}

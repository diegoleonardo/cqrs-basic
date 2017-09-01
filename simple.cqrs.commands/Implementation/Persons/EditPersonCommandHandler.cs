using simple.cqrs.commands.Interfaces;
using System;

namespace simple.cqrs.commands.Implementation.Persons
{
    public class EditPersonCommandHandler : ICommandHandler
    {
        public CommandResult Execute(ICommand command)
        {
            try
            {
                return new CommandResult()
                {
                    Success = true,
                    Message = "Success in edit person",
                    Data = command
                };
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}

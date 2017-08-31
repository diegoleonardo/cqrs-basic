using simple.cqrs.commands.Interfaces;

namespace simple.cqrs.commands.Implementation.Persons
{
    public class InsertPersonCommandHandler : ICommandHandler
    {
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

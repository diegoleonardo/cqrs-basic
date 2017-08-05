using simple.cqrs.commands.Interfaces;

namespace simple.cqrs.commands.Implementações.Persons
{
    public class InsertPersonCommandHandler : ICommandHandler<InsertPersonCommand>
    {
        public CommandResult Execute(InsertPersonCommand command)
        {
            return new CommandResult()
            {
                Success = true,
                Message = "Success"
            };
        }
    }
}

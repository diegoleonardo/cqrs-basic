using simple_cqrs.commands.Interfaces;

namespace simple_cqrs.commands.Implementações.Person
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

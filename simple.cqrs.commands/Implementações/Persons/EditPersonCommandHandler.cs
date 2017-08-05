using simple.cqrs.commands.Interfaces;

namespace simple.cqrs.commands.Implementações.Persons
{
    public class EditPersonCommandHandler : ICommandHandler<EditPersonCommand>
    {
        public CommandResult Execute(EditPersonCommand command)
        {
            return new CommandResult()
            {
                Success = true,
                Message = "Success",
                Data = command
            };
        }
    }
}

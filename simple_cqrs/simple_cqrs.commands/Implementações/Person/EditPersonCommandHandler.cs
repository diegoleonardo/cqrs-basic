using simple_cqrs.commands.Interfaces;

namespace simple_cqrs.commands.Implementações.Person
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

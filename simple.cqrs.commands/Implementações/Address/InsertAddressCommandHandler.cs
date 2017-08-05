using simple.cqrs.commands.Interfaces;

namespace simple.cqrs.commands.Implementações.Address
{
    public class InsertAddressCommandHandler : ICommandHandler<InsertAddressCommand>
    {
        public CommandResult Execute(InsertAddressCommand command)
        {
            return new CommandResult()
            {
                Success = true,
                Message = "Success"
            };
        }
    }
}

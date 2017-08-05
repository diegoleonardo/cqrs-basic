using simple.cqrs.commands.Interfaces;

namespace simple.cqrs.commands.Implementation.Address
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

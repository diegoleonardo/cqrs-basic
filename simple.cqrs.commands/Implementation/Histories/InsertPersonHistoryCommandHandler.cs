﻿using simple.cqrs.commands.Interfaces;

namespace simple.cqrs.commands.Implementation.Histories
{
    public class InsertPersonHistoryCommandHandler : ICommandHandler<InsertPersonHistoryCommand>
    {
        public CommandResult Execute(InsertPersonHistoryCommand command)
        {
            return new CommandResult()
            {
                Message = "Success",
                Success = true
            };
        }
    }
}
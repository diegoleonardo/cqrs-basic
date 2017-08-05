using simple.cqrs.commands.Implementation.Persons;
using simple.cqrs.commands.Interfaces;
using System;

namespace simple.cqrs.commands.Implementation.Histories
{
    public enum TypeOfCommand
    {
        Create = 1,
        Edit,
        Delete
    }

    public class InsertPersonHistoryCommand : ICommand
    {
        public InsertPersonCommand Person { get; private set; }
        public TypeOfCommand TypeOfHistory { get; private set; }
        public DateTime DateOfCommand { get; private set; }

        public InsertPersonHistoryCommand(InsertPersonCommand insertPersonCommand, TypeOfCommand typeOfCommand)
        {
            Person = insertPersonCommand;
            TypeOfHistory = typeOfCommand;
            DateOfCommand = DateTime.Now;
        }
    }
}

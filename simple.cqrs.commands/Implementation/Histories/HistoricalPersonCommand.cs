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

    public class HistoricalPersonCommand : ICommand
    {
        public ICommand Person { get; private set; }
        public DateTime DateOfCommand { get; private set; }

        public HistoricalPersonCommand(ICommand insertPersonCommand)
        {
            Person = insertPersonCommand;
            DateOfCommand = DateTime.Now;
        }
    }
}

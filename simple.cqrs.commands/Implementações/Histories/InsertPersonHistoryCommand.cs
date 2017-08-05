using simple.cqrs.commands.Implementações.Persons;
using simple.cqrs.commands.Interfaces;
using System;

namespace simple.cqrs.commands.Implementações.Histories
{
    public enum TypeOfCommand
    {
        Create = 1,
        Edit,
        Delete
    }

    public class InsertPersonHistoryCommand : ICommand
    {
        public InsertPersonCommand Person { get; set; }
        public TypeOfCommand TypeOfHistory { get; set; }
        public DateTime DateOfCommand { get; set; }
    }
}

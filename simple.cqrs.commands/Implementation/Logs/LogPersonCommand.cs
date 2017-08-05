using simple.cqrs.commands.Interfaces;
using System;

namespace simple.cqrs.commands.Implementation.Logs
{
    public enum TypeOfLog
    {
        CreatePerson = 1
    }

    public class LogPersonCommand : ICommand
    {
        public int Id { get; set; }
        public TypeOfLog TypeOfLog { get; set; }
        public DateTime CreatedBy { get; set; }
    }
}

using simple.cqrs.commands.Interfaces;
using System;

namespace simple.cqrs.commands.Implementation.Logs
{
    public enum TypeOfLog
    {
        CreatePerson = 1,
        EditPerson
    }

    public class LogPersonCommand : ICommand
    {
        public int Id { get; private set; }
        public TypeOfLog TypeOfLog { get; private set; }
        public DateTime CreatedBy { get; private set; }

        public LogPersonCommand()
        {
            Id = 1;
            CreatedBy = DateTime.Now;
        }
    }
}

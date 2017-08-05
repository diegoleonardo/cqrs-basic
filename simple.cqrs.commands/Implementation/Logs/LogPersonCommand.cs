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
        public int Id { get; private set; }
        public TypeOfLog TypeOfLog { get; private set; }
        public DateTime CreatedBy { get; private set; }

        public LogPersonCommand(TypeOfLog typeOfLog)
        {
            Id = 1;
            TypeOfLog = typeOfLog;
            CreatedBy = DateTime.Now;
        }
    }
}

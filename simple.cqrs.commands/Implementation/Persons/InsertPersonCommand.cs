using System;

namespace simple.cqrs.commands.Implementation.Persons
{
    public class InsertPersonCommand : PersonCommand
    {
        public InsertPersonCommand(string firstName, string lastName, DateTime birthdate) : base(firstName, lastName, birthdate)
        {
        }
    }
}

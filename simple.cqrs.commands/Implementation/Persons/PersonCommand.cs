using simple.cqrs.commands.Interfaces;
using System;

namespace simple.cqrs.commands.Implementation.Persons
{
    public class PersonCommand : ICommand
    {
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public DateTime Birthdate { get; set; }

        public PersonCommand(string firstName, string lastName, DateTime birthdate)
        {
            Firstname = firstName;
            Lastname = lastName;
            Birthdate = birthdate;
        }
    }
}

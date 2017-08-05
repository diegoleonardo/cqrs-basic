using simple.cqrs.commands.Interfaces;
using System;

namespace simple.cqrs.commands.Implementações.Persons
{
    public class PersonCommand : ICommand
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
    }
}

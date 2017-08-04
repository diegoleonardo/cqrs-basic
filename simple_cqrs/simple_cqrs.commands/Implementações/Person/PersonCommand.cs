using simple_cqrs.commands.Interfaces;
using System;

namespace simple_cqrs.commands.Implementações.Person
{
    public class PersonCommand : ICommand
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
    }
}

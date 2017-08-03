using cqrs.example.commands.Interfaces;
using System;

namespace cqrs.example.commands.Implementações
{
    public class InsertPersonCommand : ICommand
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
    }
}

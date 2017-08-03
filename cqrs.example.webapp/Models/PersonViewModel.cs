using cqrs.example.commands.Implementações;
using System;

namespace cqrs.example.webapp.Models
{
    public class PersonViewModel
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }

        public static implicit operator InsertPersonCommand(PersonViewModel person)
        {
            return new InsertPersonCommand()
            {
                Firstname = person.Firstname,
                Lastname = person.Lastname,
                Birthdate = person.Birthdate
            };
        }
    }
}

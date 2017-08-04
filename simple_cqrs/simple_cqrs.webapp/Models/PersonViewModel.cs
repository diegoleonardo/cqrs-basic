using simple_cqrs.commands.Implementações.Person;
using System;

namespace simple_cqrs.webapp.Models
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

        public static implicit operator EditPersonCommand(PersonViewModel person)
        {
            return new EditPersonCommand()
            {
                PersonId = person.Id,
                Firstname = person.Firstname,
                Lastname = person.Lastname,
                Birthdate = person.Birthdate
            };
        }
    }
}

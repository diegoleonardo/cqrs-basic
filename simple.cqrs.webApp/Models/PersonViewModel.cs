using simple.cqrs.applicationService.DataTransferObjects;
using System;

namespace simple.cqrs.webApp.Models
{
    public class PersonViewModel
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }

        public static implicit operator PersonDTO(PersonViewModel person)
        {
            return new PersonDTO()
            {
                PersonId = person.Id,
                Firstname = person.Firstname,
                Lastname = person.Lastname,
                Birthdate = person.Birthdate
            };
        }
    }
}
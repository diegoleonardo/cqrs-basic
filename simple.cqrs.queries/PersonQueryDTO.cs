using simple.cqrs.data.storage.Mocks.Domain;
using System;

namespace simple.cqrs.queries
{
    public class PersonQueryDTO
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }

        public static explicit operator PersonQueryDTO (Person person)
        {
            return new PersonQueryDTO()
            {
                Id = person.Id,
                Firstname = person.Firstname,
                Lastname = person.Lastname,
                Birthdate = person.Birthdate
            };
        }
    }
}

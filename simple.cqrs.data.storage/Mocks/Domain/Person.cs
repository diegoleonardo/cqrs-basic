using System;

namespace simple.cqrs.data.storage.Mocks.Domain
{
    public class Person
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
    }
}

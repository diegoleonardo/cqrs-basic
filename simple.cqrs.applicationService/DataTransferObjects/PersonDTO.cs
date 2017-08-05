using System;

namespace simple.cqrs.applicationService.DataTransferObjects
{
    public class PersonDTO
    {
        public int PersonId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
    }
}

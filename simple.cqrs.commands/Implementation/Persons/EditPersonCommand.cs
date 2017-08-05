using System;

namespace simple.cqrs.commands.Implementation.Persons
{
    public class EditPersonCommand : PersonCommand
    {
        public int PersonId { get; private set; }

        public EditPersonCommand(int personId, string firstName, string lastName, DateTime birthdate) : base(firstName, lastName, birthdate)
        {
            PersonId = personId;
        }
    }
}

namespace simple.cqrs.commands.Implementation.Persons
{
    public class EditPersonCommand : PersonCommand
    {
        public int PersonId { get; set; }
    }
}

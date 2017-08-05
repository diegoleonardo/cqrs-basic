namespace simple.cqrs.commands.Implementações.Persons
{
    public class EditPersonCommand : PersonCommand
    {
        public int PersonId { get; set; }
    }
}

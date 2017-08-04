namespace simple_cqrs.commands.Implementações.Person
{
    public class EditPersonCommand : PersonCommand
    {
        public int PersonId { get; set; }
    }
}

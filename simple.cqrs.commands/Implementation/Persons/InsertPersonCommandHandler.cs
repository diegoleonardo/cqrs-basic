using simple.cqrs.commands.Interfaces;
using simple.cqrs.data.storage.Mocks;
using simple.cqrs.data.storage.Mocks.Domain;

namespace simple.cqrs.commands.Implementation.Persons
{
    public class InsertPersonCommandHandler : ICommandHandler
    {
        public CommandResult Execute(ICommand command)
        {
            Person person = new Person();

            var insertCommand = (InsertPersonCommand)command;

            person.Firstname = insertCommand.Firstname;
            person.Lastname = insertCommand.Lastname;
            person.Birthdate = insertCommand.Birthdate;
            person.Id = PersonStorageSet.RetornaIdParaInsercao();

            PersonStorageSet.Persons.Add(person);

            return new CommandResult()
            {
                Success = true,
                Message = "Success",
                Data = person
            };
        }
    }
}

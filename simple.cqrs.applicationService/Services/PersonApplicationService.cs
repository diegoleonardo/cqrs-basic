using simple.cqrs.applicationService.DataTransferObjects;
using simple.cqrs.commands.Implementation.Histories;
using simple.cqrs.commands.Implementation.Logs;
using simple.cqrs.commands.Implementation.Persons;
using simple.cqrs.commands.Interfaces;

namespace simple.cqrs.applicationService.Services
{
    public class PersonApplicationService : ApplicationServiceBase, IPersonAplicationService
    {
        public PersonApplicationService(ICommandDispatcher commandDispatcher) :base(commandDispatcher)
        {
        }

        public void Insert(PersonDTO person)
        {
            ICommand insertPersonCommand = new InsertPersonCommand(person.Firstname, person.Lastname, person.Birthdate);
            var personCommandResult = CommandDispatcher.Dispatch(insertPersonCommand);

            if (personCommandResult.Success)
            {
                ICommand insertHistoricalPerson = new HistoricalPersonCommand(insertPersonCommand);
                var historyInsertPersonCommandResult = CommandDispatcher.Dispatch(insertHistoricalPerson);

                ICommand insertLogPersonCommand = new LogPersonCommand();
                var logInserPersonCommandResult = CommandDispatcher.Dispatch(insertLogPersonCommand);
            }
        }

        public void Edit(PersonDTO person)
        {
            ICommand editPersonCommand = new EditPersonCommand(person.PersonId, person.Firstname, person.Lastname, person.Birthdate);
            var editCommandResult = CommandDispatcher.Dispatch(editPersonCommand);

            if (editCommandResult.Success)
            {
                ICommand editHistoricalPerson = new HistoricalPersonCommand(editPersonCommand);
                var historyEditPersonCommandResult = CommandDispatcher.Dispatch(editPersonCommand);

                LogPersonCommand editLogPersonCommand = new LogPersonCommand();
                var logEditPersonCommandResult = CommandDispatcher.Dispatch(editLogPersonCommand);
            }
        }
    }
}

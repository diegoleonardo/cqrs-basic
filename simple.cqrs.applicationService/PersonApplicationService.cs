using Ninject;
using simple.cqrs.applicationService.DataTransferObjects;
using simple.cqrs.commands.Implementation;
using simple.cqrs.commands.Implementation.Histories;
using simple.cqrs.commands.Implementation.Logs;
using simple.cqrs.commands.Implementation.Persons;

namespace simple.cqrs.applicationService
{
    public class PersonApplicationService
    {
        private readonly CommandDispatcher _commandDispatcher;

        public PersonApplicationService()
        {
            IKernel kernel = new StandardKernel(new CommandModule());
            _commandDispatcher = new CommandDispatcher(kernel);
        }

        public void Insert(PersonDTO person)
        {
            InsertPersonCommand insertPersonCommand = new InsertPersonCommand(person.Firstname, person.Lastname, person.Birthdate);
            var personCommandResult = _commandDispatcher.Dispatch(insertPersonCommand);

            InsertPersonHistoryCommand historyInsertPerson = new InsertPersonHistoryCommand(insertPersonCommand, TypeOfCommand.Create);
            var historyInsertPersonCommandResult = _commandDispatcher.Dispatch(historyInsertPerson);

            LogPersonCommand logInsertPersonCommand = new LogPersonCommand(TypeOfLog.CreatePerson);
            var logInserPersonCommandResult = _commandDispatcher.Dispatch(logInsertPersonCommand);
        }
    }
}

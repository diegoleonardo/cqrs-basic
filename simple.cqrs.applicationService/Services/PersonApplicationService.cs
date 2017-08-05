using simple.cqrs.applicationService.CommandModules.History;
using simple.cqrs.applicationService.CommandModules.Log;
using simple.cqrs.applicationService.CommandModules.Person;
using simple.cqrs.applicationService.DataTransferObjects;
using simple.cqrs.commands.Implementation.Histories;
using simple.cqrs.commands.Implementation.Logs;
using simple.cqrs.commands.Implementation.Persons;

namespace simple.cqrs.applicationService.Services
{
    public class PersonApplicationService : ApplicationServiceBase
    {
        public PersonApplicationService()
        {
            Modules.Add(new PersonModule());
            Modules.Add(new HistoryModule());
            Modules.Add(new LogModule());

            Kernel.Load(Modules);
        }

        public void Insert(PersonDTO person)
        {
            InsertPersonCommand insertPersonCommand = new InsertPersonCommand(person.Firstname, person.Lastname, person.Birthdate);
            var personCommandResult = CommandDispatcher.Dispatch(insertPersonCommand);

            InsertPersonHistoryCommand insertHistoryPerson = new InsertPersonHistoryCommand(insertPersonCommand, TypeOfCommand.Create);
            var historyInsertPersonCommandResult = CommandDispatcher.Dispatch(insertHistoryPerson);

            LogPersonCommand insertLogPersonCommand = new LogPersonCommand(TypeOfLog.CreatePerson);
            var logInserPersonCommandResult = CommandDispatcher.Dispatch(insertLogPersonCommand);
        }
    }
}

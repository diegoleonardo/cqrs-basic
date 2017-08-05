using Ninject;
using simple.cqrs.applicationService.DataTransferObjects;
using simple.cqrs.commands.Implementações;
using simple.cqrs.commands.Implementações.Histories;
using simple.cqrs.commands.Implementações.Logs;
using simple.cqrs.commands.Implementações.Persons;
using System;

namespace simple.cqrs.applicationService
{
    public class PersonApplicationService
    {
        private readonly CommandDispatcher commandDispatcher;

        public PersonApplicationService()
        {
            var kernel = new StandardKernel(new CommandModule());

            commandDispatcher = new CommandDispatcher(kernel);
        }

        public void Insert(PersonDTO person)
        {
            InsertPersonCommand insertPersonCommand = new InsertPersonCommand()
            {
                Firstname = person.Firstname,
                Lastname = person.Lastname,
                Birthdate = person.Birthdate
            };

            var personCommandResult = commandDispatcher.Dispatch(insertPersonCommand);

            InsertPersonHistoryCommand historyInsertPerson = new InsertPersonHistoryCommand()
            {
                Person = insertPersonCommand,
                TypeOfHistory = TypeOfCommand.Create,
                DateOfCommand = DateTime.Now
            };

            var historyInsertPersonCommandResult = commandDispatcher.Dispatch(historyInsertPerson);

            LogPersonCommand logInsertPersonCommand = new LogPersonCommand() {
                Id = 1,
                TypeOfLog = TypeOfLog.CreatePerson,
                CreatedBy = DateTime.Now
            };

            var logInserPersonCommandResult = commandDispatcher.Dispatch(logInsertPersonCommand);
        }
    }
}

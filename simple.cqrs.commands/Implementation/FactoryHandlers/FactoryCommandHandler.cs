using simple.cqrs.commands.Implementation.Histories;
using simple.cqrs.commands.Implementation.Logs;
using simple.cqrs.commands.Implementation.Persons;
using simple.cqrs.commands.Interfaces;

namespace simple.cqrs.commands.Implementation.FactoryHandlers
{
    public static class FactoryCommandHandler
    {

        public static ICommandHandler GetCommandHandler(ICommand command)
        {
            ICommandHandler commandHandler = null;

            if (command.GetType() == typeof(InsertPersonCommand))
                commandHandler = new InsertPersonCommandHandler();
            else if (command.GetType() == typeof(EditPersonCommand))
                commandHandler = new EditPersonCommandHandler();
            else if (command.GetType() == typeof(HistoricalPersonCommand))
                commandHandler = new HistoricalPersonCommandHandler();
            else if (command.GetType() == typeof(LogPersonCommand))
                commandHandler = new LogPersonCommandHandler();

            return commandHandler;
        }
    }
}

using simple.cqrs.data.storage.Mocks;
using simple.cqrs.data.storage.Mocks.Domain;
using simple.cqrs.queries.Implementation.QueryResults;
using simple.cqrs.queries.Interfaces;
using System;
using System.Linq;

namespace simple.cqrs.queries.Implementation.Handlers
{
    public class FindByNameQueryHandler : IQueryHandler<IQueryResult, IQuery>
    {
        public IQueryResult Retrieve(IQuery query)
        {
            FindPersonByNameParameter  personQuery = (FindPersonByNameParameter )query;

            Func<Person, bool> predicate = x => (x.Firstname.Contains(personQuery.Name));

            var result = PersonStorageSet.Persons.Where(predicate).FirstOrDefault();

            if (result == null)
                return null;

            var queryResult = new FindByNamePersonQueryResult(result.Id, result.Firstname, result.Lastname, result.Birthdate);

            return queryResult;
        }
    }
}

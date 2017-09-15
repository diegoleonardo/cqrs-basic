using System;
using simple.cqrs.queries.Interfaces;
using simple.cqrs.queries.Implementation.Queries;
using simple.cqrs.queries.Implementation.QueryResults;
using simple.cqrs.data.storage.Mocks;

namespace simple.cqrs.queries.Implementation.Handlers
{
    public class FindAllPersonsQueryHandler : IQueryHandler<FindAllPersonsQueryResult, FindAllPersonsParam>
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public FindAllPersonsQueryResult Retrieve(FindAllPersonsParam query)
        {
            var result = PersonStorageSet.Persons;
            var queryResult = new FindAllPersonsQueryResult();

            if (result != null)
            {
                foreach(var person in result)
                {
                    PersonQueryDTO personDTO = (PersonQueryDTO) person;
                    queryResult.personList.Add(personDTO);
                }
            }

            return queryResult;
        }
    }
}

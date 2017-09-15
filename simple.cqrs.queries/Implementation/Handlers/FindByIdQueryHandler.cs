using simple.cqrs.data.storage.Mocks;
using simple.cqrs.queries.Interfaces;
using System;
using System.Linq;

namespace simple.cqrs.queries.Implementation
{
    public class PersonQueryHandler : IQueryHandler<FindByIdQueryResult, FindPersonByIdQueryParameter>
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public FindByIdQueryResult Retrieve(FindPersonByIdQueryParameter query)
        {
            var result = PersonStorageSet.Persons.Where(x=>x.Id.ToString().Equals(query.Identifier)).FirstOrDefault();

            if (result == null)
                return FindByIdQueryResult.NoResult();

            var queryResult = new FindByIdQueryResult(result.Id, result.Firstname, result.Lastname, result.Birthdate);

            return queryResult;
        }
    }
}

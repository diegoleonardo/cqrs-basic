using simple.cqrs.data.storage.Mocks;
using simple.cqrs.queries.Interfaces;
using System.Linq;

namespace simple.cqrs.queries.Implementation
{
    public class PersonQueryHandler : IQueryHandler<IQueryResult, IQuery>
    {
        public IQueryResult Retrieve(IQuery query)
        {
            var result = PersonStorageSet.Persons.Where(x=>x.Id.ToString().Equals(query.Identifier)).FirstOrDefault();

            if (result == null)
                return null;

            var queryResult = new FindByIdQueryResult(result.Id, result.Firstname, result.Lastname, result.Birthdate);

            return queryResult;
        }
    }
}

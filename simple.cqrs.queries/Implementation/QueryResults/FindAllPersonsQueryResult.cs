using simple.cqrs.queries.Interfaces;
using System.Collections.Generic;

namespace simple.cqrs.queries.Implementation.QueryResults
{
    public class FindAllPersonsQueryResult: IQueryResult
    {
        public IList<PersonQueryDTO> personList { get; set; }
        public bool HasResult { get; set; }

        public FindAllPersonsQueryResult()
        {
            personList = new List<PersonQueryDTO>();
        }
    }
}

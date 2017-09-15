using System;
using simple.cqrs.queries.Interfaces;

namespace simple.cqrs.queries.Implementation.QueryResults
{
    public class FindByNamePersonQueryResult: IQueryResult
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        public bool HasResult { get; set; }
        internal FindByNamePersonQueryResult() { }
        public FindByNamePersonQueryResult(int id, string firstname, string lastname, DateTime birthdate)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Birthdate = birthdate;
            HasResult = true;
        }

        public static FindByNamePersonQueryResult NoResult()
        {
            return new FindByNamePersonQueryResult();
        }
    }
}

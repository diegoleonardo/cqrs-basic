﻿using simple.cqrs.queries.Interfaces;
using System;

namespace simple.cqrs.queries.Implementation
{
    public class FindByIdQueryResult : IQueryResult
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        public bool HasResult { get; set; }
        internal FindByIdQueryResult() { }
        public FindByIdQueryResult(int id, string firstName, string lastname, DateTime birthdate)
        {
            Id = id;
            Firstname = firstName;
            Lastname = lastname;
            Birthdate = birthdate;
            HasResult = true;
        }

        public static FindByIdQueryResult NoResult()
        {
            return new FindByIdQueryResult();
        }
    }
}

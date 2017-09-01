﻿using simple.cqrs.queries.Implementation.Handlers;
using simple.cqrs.queries.Interfaces;

namespace simple.cqrs.queries.Implementation
{
    public static class FactoryQueryHandler
    {
        public static IQueryHandler<IQueryResult, IQuery> GetQueryHandler(IQuery query)
        {
            IQueryHandler<IQueryResult, IQuery> queryHandler = null;

            if (query.GetType() == typeof(FindPersonByIdQueryParameter))
                queryHandler = new PersonQueryHandler();
            else if(query.GetType() == typeof(FindPersonByNameParameter ))
                queryHandler = new FindByNameQueryHandler();

            return queryHandler;
        }
    }
}

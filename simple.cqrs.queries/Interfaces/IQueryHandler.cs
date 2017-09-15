using System;

namespace simple.cqrs.queries.Interfaces
{
    public interface IQueryHandler<TResult,TParameter>: IDisposable
        where TParameter : IQuery
         where TResult : IQueryResult
    {
        TResult Retrieve(TParameter query);
    }
}

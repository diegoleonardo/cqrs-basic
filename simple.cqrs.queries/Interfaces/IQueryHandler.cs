namespace simple.cqrs.queries.Interfaces
{
    public interface IQueryHandler<TResult,TParameter>
        where TParameter : IQuery
         where TResult : IQueryResult
    {
        TResult Retrieve(TParameter query);
    }
}

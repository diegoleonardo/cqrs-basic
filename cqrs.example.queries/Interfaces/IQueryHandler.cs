namespace cqrs.example.queries.Interfaces
{
    public interface IQueryHandler<TParameter, TResult>
        where TResult : IQueryResult
        where TParameter : IQuery
    {
        TResult Retrieve(TParameter query);
    }
}

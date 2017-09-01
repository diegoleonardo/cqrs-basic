namespace simple.cqrs.queries.Interfaces
{
    public interface IQueryDispatcher
    {
        TResult Dispatch<TResult, TParameter>(TParameter query)
            where TParameter : IQuery
            where TResult : IQueryResult;
    }
}

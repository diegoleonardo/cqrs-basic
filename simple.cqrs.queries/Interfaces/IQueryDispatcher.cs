namespace simple.cqrs.queries.Interfaces
{
    public interface IQueryDispatcher
    {
        IQueryResult Dispatch<TParameter>(TParameter query)
            where TParameter : IQuery;
    }
}

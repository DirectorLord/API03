namespace E_Commerce.Persistence.Repositories;

internal static class SpecificationEvaluation
{
    public static IQueryable<TEntity> ApplySpecification<TEntity>(this IQueryable<TEntity> inputQuery,ISpecification<TEntity> specification)
        where TEntity : class
    {
        var query = inputQuery;
        //foreach(var include in specification.Includes)
        //{
        //    query = query.Include(include);
        //}
        query = specification.Includes.Aggregate(query, (query, include) => query.Include(include));
        return query;
    }
}

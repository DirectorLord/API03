namespace E_Commerce.Persistence.Repositories;

internal static class SpecificationEvaluation
{
    public static IQueryable<TEntity> ApplySpecification<TEntity>(this IQueryable<TEntity> inputQuery,ISpecification<TEntity> specification)
        where TEntity : class
    {
        var query = inputQuery;
        if(specification.Criteria is not null)
        {
             query = query.Where(specification.Criteria);
        }
        foreach (var include in specification.Includes)
        {
            query = query.Include(include);
        }
        return query;
    }
}

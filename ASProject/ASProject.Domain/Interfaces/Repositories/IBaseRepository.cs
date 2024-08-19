using ASProject.Domain.Interfaces.Databases;

namespace ASProject.Domain.Interfaces.Repositories;

public interface IBaseRepository<TEntity> : IStateSaveChanges
{
    IQueryable<TEntity> GetAll();
    
    Task<TEntity> CreateAsync(TEntity entity);

    TEntity Update(TEntity entity);
    
    void Remove(TEntity entity);
}
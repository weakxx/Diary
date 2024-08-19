using ASProject.Domain.Entity;
using ASProject.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore.Storage;

namespace ASProject.Domain.Interfaces.Databases;

public interface IUnitOfWork : IStateSaveChanges
{
    Task<IDbContextTransaction> BeginTransactionAsync();
    
    IBaseRepository<User> Users { get; set; }
    
    IBaseRepository<Role> Roles { get; set; }
    
    IBaseRepository<UserRole> UserRoles { get; set; }
}
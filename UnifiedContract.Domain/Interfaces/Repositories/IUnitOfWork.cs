using System;
using System.Threading.Tasks;

namespace UnifiedContract.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TEntity> Repository<TEntity>() where TEntity : class;
        Task<int> CompleteAsync();
        Task<bool> SaveEntitiesAsync();
    }
} 
using BidStream.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BidStream.Application.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default, bool asNoTracking = true);
        Task<T?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);



        //   Task CommitTransactionAsync(CancellationToken cancellationToken);
        //    Task RollbackTransactionAsync(CancellationToken cancellationToken);
        //  IDbContextTransaction BeginTransaction();
    }
}

using BidStream.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BidStream.Application.Interfaces
{
    public interface IUnitOfWork
    {
        ICategoryRepository CategoriesRepo { get; }
        IItemRepository ItemsRepo { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}

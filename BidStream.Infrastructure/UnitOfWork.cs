using BidStream.Application.Interfaces;
using BidStream.Application.Interfaces.Repositories;
using BidStream.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BidStream.Infrastructure
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        public UnitOfWork(
            AppDbContext appDbContext,
             ICategoryRepository categoriesRepo,
             IItemRepository itemsRepo)
        {
            _appDbContext = appDbContext;
            CategoriesRepo = categoriesRepo;
            ItemsRepo = itemsRepo;
        }

        public ICategoryRepository CategoriesRepo { get; }
        public IItemRepository ItemsRepo { get; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return _appDbContext.SaveChangesAsync(cancellationToken);
        }
    }
}

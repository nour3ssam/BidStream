using BidStream.Application.Interfaces.Repositories;
using BidStream.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BidStream.Infrastructure.Repositories
{
    internal class CategoryRepository :BaseRepository<Category>, ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;
        public CategoryRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

    }
}

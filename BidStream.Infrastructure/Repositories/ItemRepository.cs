using BidStream.Application.Interfaces.Repositories;
using BidStream.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BidStream.Infrastructure.Repositories
{
    internal class ItemRepository : BaseRepository<Item>, IItemRepository
    {
        private readonly AppDbContext _appDbContext;
        public ItemRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

    }
}

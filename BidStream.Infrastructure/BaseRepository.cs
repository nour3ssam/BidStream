using BidStream.Application.Interfaces;
using BidStream.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;

namespace BidStream.Infrastructure
{
    internal class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default, bool asNoTracking = true)
        {
            IQueryable<T> query = _context.Set<T>();

            if (asNoTracking)
            {
                query = query.AsNoTracking();
            }

            if (predicate is not null)
            {
                query = query.Where(predicate);
            }

            return await query.ToListAsync(cancellationToken);
        }

        public async Task<T?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await _context.Set<T>().FindAsync(id, cancellationToken);
        }
        public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default)
        {
            return await _context.Set<T>().AnyAsync(predicate, cancellationToken);
        }
        public void Add(T entity)
        {
             _context.Set<T>().Add(entity);
        }

        public void Update(T entity) 
        {
            _context.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
             _context.Set<T>().Remove(entity);
        }


    }
}

using MeetingRoom.Models;
using MeetingRoom.Models.Interface;
using MeetingRoom.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingRoom.Repository.EFCore
{
    public abstract class EfCoreRepository <TEntity, TContext> : IGenericRepository<TEntity>
        where TEntity : class, IEntity
        where TContext : DbContext
    {

        private readonly TContext _context;
        public EfCoreRepository(TContext context)
        {
            _context = context;
        }

        public async Task<bool> Create(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<bool> Update(TEntity entity)
        {
            var current = await GetById(entity.Id);

            _context.Entry(current).CurrentValues.SetValues(entity);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}

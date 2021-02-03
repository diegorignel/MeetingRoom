using MeetingRoom.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingRoom.Repository.Interface
{
    public interface IGenericRepository<TEntity> where TEntity : class, IEntity
    {
        Task<List<TEntity>> GetAll();

        Task<TEntity> GetById(int id);

        Task<bool> Create(TEntity entity);

        Task<bool> Update(TEntity entity);

        Task<bool> Delete(TEntity entity);
    }
}

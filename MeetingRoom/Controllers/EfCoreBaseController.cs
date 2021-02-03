using MeetingRoom.Models.Interface;
using MeetingRoom.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace MeetingRoom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class EfCoreBaseController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IGenericRepository<TEntity>
    {
        private readonly TRepository _repository;
        public EfCoreBaseController(TRepository repository)
        {
            _repository = repository;
        }


        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await _repository.GetAll();
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var movie = await _repository.GetById(id);
            if (movie == null)
            {
                return NotFound();
            }
            return movie;
        }

        // PUT: api/[controller]
        [HttpPut]
        public async Task<IActionResult> Put(TEntity entity)
        {
            if (entity.Id == 0)
            {
                return BadRequest();
            }

            await _repository.Update(entity);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult> Post(TEntity entity)
        {
            var success = await _repository.Create(entity);
            if (!success)
                return BadRequest(entity);

            return Ok(entity);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(TEntity entity)
        {
            var deleted = await _repository.Delete(entity);
            if (!deleted)
            {
                return NotFound();
            }
            return NoContent();
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using APIDOJO.Interfaces;

namespace APIDOJO.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController<TModel, TService> : ControllerBase
        where TModel : class
        where TService : IBaseService<TModel>
    {
        protected readonly TService _service;

        public BaseController(TService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<TModel>>> GetAll()
        {
            var result = await _service.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TModel>> GetById(int id)
        {
            var entity = await _service.GetById(id);
            return entity == null ? NotFound() : Ok(entity);
        }

        [HttpPost]
        public async Task<ActionResult<TModel>> Add(TModel entity)
        {
            var added = await _service.Add(entity);
            return Ok(added);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TModel>> Update(int id, TModel entityAtualizada)
        {
            var entity = await _service.Update(id, entityAtualizada);
            if (entity == null)
                return NotFound();

            return Ok(entity);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _service.Delete(id);
            return deleted ? NoContent() : NotFound();
        }
    }
}

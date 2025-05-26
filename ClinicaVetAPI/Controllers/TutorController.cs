using ClinicaVetAPI.Interfaces;
using ClinicaVetAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaVetAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TutorController : ControllerBase
    {
        private readonly IBaseService<Tutor> _tutorService;

        public TutorController(IBaseService<Tutor> tutorService)
        {
            _tutorService = tutorService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Tutor>>> GetAll()
        {
            var tutores = await _tutorService.GetAll();
            return Ok(tutores);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Tutor>> GetById(int id)
        {
            var tutor = await _tutorService.GetById(id);
            if (tutor == null)
                return NotFound();

            return Ok(tutor);
        }

        [HttpPost]
        public async Task<ActionResult<Tutor>> Add(Tutor tutor)
        {
            var newTutor = await _tutorService.Add(tutor);
            return CreatedAtAction(nameof(GetById), new { id = newTutor.Id }, newTutor);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Tutor>> Update(int id, Tutor tutor)
        {
            var updatedTutor = await _tutorService.Update(id, tutor);
            if (updatedTutor == null)
                return NotFound();

            return Ok(updatedTutor);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _tutorService.Delete(id);
            if (!deleted)
                return NotFound();

            return NoContent();
        }
    }
}

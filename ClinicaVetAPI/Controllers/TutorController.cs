using AutoMapper;
using ClinicaVetAPI.DTO;
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
        private readonly IMapper _mapper;

        public TutorController(IBaseService<Tutor> tutorService, IMapper mapper)
        {
            _tutorService = tutorService;
            _mapper = mapper;
        }

        /// <summary>
        /// Retorna todos os tutores cadastrados.
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<List<TutorDTO>>> GetAll()
        {
            var tutores = await _tutorService.GetAll();
            var tutorDTOs = _mapper.Map<List<TutorDTO>>(tutores);
            return Ok(tutorDTOs);
        }

        /// <summary>
        /// Retorna um tutor pelo ID.
        /// </summary>
        /// <param name="id">ID do tutor.</param>
        [HttpGet("{id}")]
        public async Task<ActionResult<TutorDTO>> GetById(int id)
        {
            var tutor = await _tutorService.GetById(id);
            if (tutor == null)
                return NotFound();

            var tutorDTO = _mapper.Map<TutorDTO>(tutor);
            return Ok(tutorDTO);
        }

        /// <summary>
        /// Cadastra um novo tutor.
        /// </summary>
        /// <param name="dto">Dados do tutor.</param>
        [HttpPost]
        public async Task<ActionResult<TutorDTO>> Add([FromBody] TutorDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var tutor = _mapper.Map<Tutor>(dto);
            var created = await _tutorService.Add(tutor);
            var createdDTO = _mapper.Map<TutorDTO>(created);

            return CreatedAtAction(nameof(GetById), new { id = created.Id }, createdDTO);
        }

        /// <summary>
        /// Atualiza um tutor existente.
        /// </summary>
        /// <param name="id">ID do tutor.</param>
        /// <param name="dto">Dados atualizados do tutor.</param>
        [HttpPut("{id}")]
        public async Task<ActionResult<TutorDTO>> Update(int id, [FromBody] TutorDTO dto)
        {
            var tutor = _mapper.Map<Tutor>(dto);
            tutor.Id = id;

            var updated = await _tutorService.Update(id, tutor);
            if (updated == null)
                return NotFound();

            var updatedDTO = _mapper.Map<TutorDTO>(updated);
            return Ok(updatedDTO);
        }

        /// <summary>
        /// Remove um tutor do sistema.
        /// </summary>
        /// <param name="id">ID do tutor.</param>
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

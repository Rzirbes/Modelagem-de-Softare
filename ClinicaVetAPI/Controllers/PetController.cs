using AutoMapper;
using ClinicaVetAPI.DTO;
using ClinicaVetAPI.Interfaces;
using ClinicaVetAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaVetAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PetController : ControllerBase
    {
        private readonly IBaseService<Pet> _petService;
        private readonly IMapper _mapper;

        public PetController(IBaseService<Pet> petService, IMapper mapper)
        {
            _petService = petService;
            _mapper = mapper;
        }

        /// <summary>
        /// Retorna todos os pets cadastrados.
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<List<PetDTO>>> GetAll()
        {
            var pets = await _petService.GetAll();
            var petDTOs = _mapper.Map<List<PetDTO>>(pets);
            return Ok(petDTOs);
        }

        /// <summary>
        /// Retorna um pet pelo ID.
        /// </summary>
        /// <param name="id">ID do pet.</param>
        [HttpGet("{id}")]
        public async Task<ActionResult<PetDTO>> GetById(int id)
        {
            var pet = await _petService.GetById(id);
            if (pet == null)
                return NotFound();

            var petDTO = _mapper.Map<PetDTO>(pet);
            return Ok(petDTO);
        }

        /// <summary>
        /// Cadastra um novo pet.
        /// </summary>
        /// <param name="dto">Dados do pet.</param>
        [HttpPost]
        public async Task<ActionResult<PetDTO>> Add([FromBody] PetDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var pet = _mapper.Map<Pet>(dto);
            var created = await _petService.Add(pet);
            var createdDTO = _mapper.Map<PetDTO>(created);

            return CreatedAtAction(nameof(GetById), new { id = created.Id }, createdDTO);
        }

        /// <summary>
        /// Atualiza um pet existente.
        /// </summary>
        /// <param name="id">ID do pet.</param>
        /// <param name="dto">Dados atualizados do pet.</param>
        [HttpPut("{id}")]
        public async Task<ActionResult<PetDTO>> Update(int id, [FromBody] PetDTO dto)
        {
            var pet = _mapper.Map<Pet>(dto);
            pet.Id = id;

            var updated = await _petService.Update(id, pet);
            if (updated == null)
                return NotFound();

            var updatedDTO = _mapper.Map<PetDTO>(updated);
            return Ok(updatedDTO);
        }

        /// <summary>
        /// Remove um pet do sistema.
        /// </summary>
        /// <param name="id">ID do pet.</param>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _petService.Delete(id);
            if (!deleted)
                return NotFound();

            return NoContent();
        }
    }
}

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

        public PetController(IBaseService<Pet> petService)
        {
            _petService = petService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Pet>>> GetAll()
        {
            var pets = await _petService.GetAll();
            return Ok(pets);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Pet>> GetById(int id)
        {
            var pet = await _petService.GetById(id);
            if (pet == null)
                return NotFound();

            return Ok(pet);
        }

        [HttpPost]
        public async Task<ActionResult<Pet>> Add(Pet pet)
        {
            var newPet = await _petService.Add(pet);
            return CreatedAtAction(nameof(GetById), new { id = newPet.Id }, newPet);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Pet>> Update(int id, Pet pet)
        {
            var updatedPet = await _petService.Update(id, pet);
            if (updatedPet == null)
                return NotFound();

            return Ok(updatedPet);
        }

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

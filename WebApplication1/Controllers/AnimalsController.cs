using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTOs;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/animals")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private IAnimalService _animalService;
        public AnimalsController(IAnimalService animalService)
        {
            _animalService = animalService;
        }

        [HttpGet]
        public IActionResult GetAnimals(string orderBy = "Name")
        {
            return Ok(_animalService.GetAnimals(orderBy));
        }

        [HttpPost]
        public ActionResult<Animal> CreateAnimal(AnimalCreationDTO animal)
        {
            var id = _animalService.CreateAnimal(animal);
            return CreatedAtAction(nameof(CreateAnimal), id);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAnimal(int id, AnimalUpdateDTO animalUpdated)
        {
            var animal = _animalService.GetAnimalById(id);

            if (animal == null)
            {
                return NotFound();
            }

            _ = _animalService.UpdateAnimal(id, animalUpdated);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAnimal(int id)
        {
            var animal = _animalService.GetAnimalById(id);

            if (animal == null)
            {
                return NotFound();
            }

            _ = _animalService.DeleteAnimal(id);

            return NoContent();
        }
    }


}

using WebApplication1.DTOs;

namespace WebApplication1.Services
{
    public interface IAnimalService
    {
        public int CreateAnimal(AnimalCreationDTO animal);
        public int DeleteAnimal(int id);
        public AnimalDTO GetAnimalById(int id);
        public IEnumerable<AnimalDTO> GetAnimals(string orderBy);
        public int UpdateAnimal(int id, AnimalUpdateDTO animalUpdated);
    }
}
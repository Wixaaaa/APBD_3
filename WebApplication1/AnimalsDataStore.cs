using WebApplication1.Models;

namespace WebApplication1
{
    public class AnimalsDataStore
    {
        public List<Animal> Animals { get; set; }
        public static AnimalsDataStore Current { get; } = new AnimalsDataStore();
        public AnimalsDataStore()
        {
            Animals = new List<Animal>()
            {
                 new Animal
                 {
                     Id = 1,
                     Name = "Cat",
                     Description = "Feline",
                     Category = "Mammals",
                     Area = "Worldwide"
                 },
                 new Animal
                 {
                    Id = 2,
                    Name = "Dog",
                    Description = "Canis",
                    Category = "Mammals",
                    Area = "Worldwide"
                 },
                 new Animal
                 {
                    Id = 3,
                    Name = "Parrot",
                    Description = "Aves",
                    Category = "Birds",
                    Area = "Africa, Australia, America, Asia"
                 },
            };
        }
    }
}

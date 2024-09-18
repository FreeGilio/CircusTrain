using CircusTrein.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Classes
{
    public class Wagon
    {
        public int Id { get; set; }
        public List<Animal> animals { get; private set; }
        public int CurrentPoints { get; private set; }

        public Wagon(int id)
        {
            Id = id;
            animals = new List<Animal>();
            CurrentPoints = 0;
        }

        public bool TryAddAnimalToWagon(Animal animal)
        {
            try
            {
              
                if(!IsAnimalCompatibleWithAnimalsInWagon(animal))
                {
                    throw new AnimalIncompatibilityException($"Animal {animal.Name} is not compatible with existing animals in wagon {Id}.");
                }
                

                if (!IsWagonPointsExceeded(animal))
                {
                    throw new WagonCapacityExceededException("Wagon capacity exceeded.");

                }

                animals.Add(animal);
                CurrentPoints += animal.GetPoints();
                return true;

            }
            catch (AnimalIncompatibilityException ex)
            {
                Console.WriteLine($"Compatibility Error: {ex.Message}");
                return false;
            }
            catch (WagonCapacityExceededException ex)
            {
                Console.WriteLine($"Capacity Error: {ex.Message}");
                return false;
            }
        }


        private bool IsAnimalCompatibleWithAnimalsInWagon(Animal animal)
        {
            foreach (var existingAnimal in animals)
            {
                if (!existingAnimal.CheckIfCompatible(animal))
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsWagonPointsExceeded(Animal animal)
        {
            if (animal.GetPoints() + CurrentPoints > 10)
            {
                return false;

            }
            return true;
        }
    }

}

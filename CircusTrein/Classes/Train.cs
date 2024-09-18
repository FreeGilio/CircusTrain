using CircusTrein.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Classes
{
    public class Train
    {
        public List<Wagon> wagons { get; set; }
        public Train()
        {
            wagons = new List<Wagon>();
        }


        public void AddAnimalToTrain()
        {
            try
            {
                Console.WriteLine("Enter the animal name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the animal's size (Small, Medium, Large)");
                string size = Console.ReadLine();
                AnimalSize sizeEnum = size switch
                {
                    "Small" => AnimalSize.Small,
                    "Medium" => AnimalSize.Medium,
                    "Large" => AnimalSize.Large,
                    _ => throw new InvalidAnimalInputException("Invalid animal size.")
                };

                Console.WriteLine("Enter the animal's diet (Carnivore, Herbivore)");
                string diet = Console.ReadLine();
                AnimalDiet dietEnum = diet switch
                {
                    "Carnivore" => AnimalDiet.Carnivore,
                    "Herbivore" => AnimalDiet.Herbivore,
                    _ => throw new InvalidAnimalInputException("Invalid animal diet.")
                };

                Animal animal = new Animal(name, sizeEnum, dietEnum);

                AddWagonToTrain(animal);

                Console.WriteLine($"{animal.Name} added to the train.");

                Console.WriteLine("Add another animal? (Y/N)");
                string confirm = Console.ReadLine();
                if (confirm == "Y")
                {
                    AddAnimalToTrain();
                }
                else if (confirm == "N")
                {
                    DisplayTrain();
                }
                else
                {
                    DisplayTrain();
                }
            }
            catch (InvalidAnimalInputException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }

        public void AddWagonToTrain(Animal animal)
        {

            try
            {
                bool added = false;

                foreach (var wagon in wagons)
                {
                    if (wagon.TryAddAnimalToWagon(animal))
                    {
                        added = true;
                        break;
                    }
                }

                if (!added)
                {
                    Wagon newWagon = new Wagon(wagons.Count + 1);
                    if (!newWagon.TryAddAnimalToWagon(animal))
                    {
                        throw new WagonCapacityExceededException("Failed to add animal to new wagon due to capacity issues.");
                    }
                    wagons.Add(newWagon);
                }
            }
            catch (WagonCapacityExceededException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
           

        public void DisplayTrain()
        {
            Console.WriteLine("Train Details:");
            foreach (var wagon in wagons)
            {
                Console.WriteLine($"Wagon {wagon.Id} (Current Points: {wagon.CurrentPoints}):");
                foreach (var animal in wagon.animals)
                {
                    Console.WriteLine($"  Animal Name: {animal.Name}, Size: {animal.GetPoints()} point(s), Diet: {animal.Diet}");
                }
            }
        }

    }
}

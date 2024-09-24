// See https://aka.ms/new-console-template for more information
using CircusTrein.Classes;
using System.Drawing;


Train train = new Train();


train.AddAnimalToTrain(new Animal(AnimalSize.Small, AnimalDiet.Carnivore));
train.AddAnimalToTrain(new Animal(AnimalSize.Large, AnimalDiet.Herbivore));
train.AddAnimalToTrain(new Animal(AnimalSize.Large, AnimalDiet.Herbivore));
train.AddAnimalToTrain(new Animal(AnimalSize.Medium, AnimalDiet.Herbivore));
train.AddAnimalToTrain(new Animal(AnimalSize.Small,AnimalDiet.Herbivore));

train.SortAndOptimizeWagons();

train.DisplayTrain();










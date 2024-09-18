// See https://aka.ms/new-console-template for more information
using CircusTrein.Classes;
using System.Drawing;


Train train = new Train();


train.AddAnimalToTrain(new Animal("Test3", AnimalSize.Large, AnimalDiet.Carnivore));
train.AddAnimalToTrain(new Animal("Test2", AnimalSize.Medium, AnimalDiet.Carnivore));
train.AddAnimalToTrain(new Animal("Test1", AnimalSize.Small,AnimalDiet.Carnivore));
train.AddAnimalToTrain(new Animal("Test4", AnimalSize.Large, AnimalDiet.Herbivore));
train.AddAnimalToTrain(new Animal("Test5", AnimalSize.Medium, AnimalDiet.Herbivore));
train.AddAnimalToTrain(new Animal("Test6", AnimalSize.Small, AnimalDiet.Herbivore));
/*train.AddAnimalToTrain(new Animal("Test7", AnimalSize.Small, AnimalDiet.Herbivore));
train.AddAnimalToTrain(new Animal("Test8", AnimalSize.Small, AnimalDiet.Herbivore));
train.AddAnimalToTrain(new Animal("Test9", AnimalSize.Small, AnimalDiet.Herbivore));*/

train.DisplayTrain();








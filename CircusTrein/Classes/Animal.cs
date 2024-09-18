using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Classes
{
    public enum AnimalSize { Small = 1, Medium = 3, Large = 5};

    public enum AnimalDiet { Carnivore, Herbivore };

    public class Animal
    {
        public string Name { get; private set; }

        private AnimalSize _size;

        private AnimalDiet _diet;

        public AnimalSize Size => _size;
        public AnimalDiet Diet => _diet;

        public Animal(string name, AnimalSize size, AnimalDiet diet) 
        {
            this.Name = name;
            _size = size;
            _diet = diet;
        }

        public int GetPoints()
        {  
            return (int)_size;
        }

        public bool CheckIfCompatible(Animal animal)
        {
            if ((_diet == AnimalDiet.Carnivore && _size >= animal.Size) ||
                (animal.Diet == AnimalDiet.Carnivore && animal.Size >= _size))
            {
                return false;
            }
            return true;
        }


    }
}

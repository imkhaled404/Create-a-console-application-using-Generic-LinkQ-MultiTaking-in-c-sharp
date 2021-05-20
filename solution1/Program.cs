using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvedenceModelTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cow = new Animal { Name = "cow", Age = 2, Type = AnimalType.mammals, Gender = AnimalGender.Male };
            GenericAnimal<Animal> animal = new GenericAnimal<Animal>();
            Console.WriteLine(animal.GetGenericAnimal(cow));

            Animal bir = new Animal { Name = "Mackpai", Age = 4, Type = AnimalType.birds, Gender = AnimalGender.Male };
            SpecificAnimal<Animal> obj2 = new SpecificAnimal<Animal>();
            Console.WriteLine(obj2.GetTypeSpecificBehavior(bir));
            Console.ReadKey();
        }
    }
}

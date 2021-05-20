using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvedenceModelTest
{
    public class GenericAnimal<T> : IGenericAnimal<T>
    {
        public string GetGenericAnimal(T obj)
        {
            string behavior = string.Empty;
            if (obj is Animal)
            {
                Animal a = obj as Animal;
                switch (a.Type)
                {
                    case AnimalType.amphibians:
                        behavior = "Amphibians are unique in their ability to live both on land and in water.";
                        break;
                    case AnimalType.birds:
                        behavior = "The Birds Can Fly";
                        break;
                    case AnimalType.fish:
                        behavior = "The Fish Can Swimming";
                        break;
                    case AnimalType.invertebrates:
                        behavior = "The invertebrates lack backbones";
                        break;
                    case AnimalType.mammals:
                        behavior = "Mammals is a notoriously difficult undertaking";
                        break;
                    default:
                        behavior = "unknown behavior";
                        break;
                }
            }
            else { behavior = "Not an animal"; }
            return behavior;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvedenceModelTest
{
 
    public class SpecificAnimal<T> : ITypeSpecificBehavior<T>
    {

        public string GetTypeSpecificBehavior<T>(T obj2) where T : Animal
        {
            string behavior = string.Empty;
            switch (obj2.Type)
            {
                case AnimalType.amphibians:
                    behavior = "There are about 6,200 species of amphibians on Earth today.";
                    break;
                case AnimalType.birds:
                    behavior = "The earth is home to over 10,000 species of birds";
                    break;
                case AnimalType.fish:
                    behavior = "Fish is an informal term and it does not correspond to a single taxonomic group";
                    break;
                case AnimalType.invertebrates:
                    behavior = "The invertebrates 31 different groups";
                    break;
                case AnimalType.mammals:
                    behavior = "ALL the other confusing terms biologists use when untangling the branches of the tree of life";
                    break;
                default:
                    behavior = "unknown behavior";
                    break;

            }
            return behavior;
        }

    }
}

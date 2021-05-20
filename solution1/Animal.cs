using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvedenceModelTest
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public AnimalType Type { get; set; }
        public AnimalGender Gender { get; set; }
    }
}

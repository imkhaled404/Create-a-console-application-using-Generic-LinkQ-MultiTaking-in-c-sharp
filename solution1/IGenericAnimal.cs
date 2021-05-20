using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvedenceModelTest
{
    public interface IGenericAnimal<T>
    {
        string GetGenericAnimal(T obj);
    }
}

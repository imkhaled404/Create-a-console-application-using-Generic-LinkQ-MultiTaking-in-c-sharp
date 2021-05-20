using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvedenceModelTest
{
    public interface ITypeSpecificBehavior<T>
    {
        string GetTypeSpecificBehavior<T>(T obj2) where T : Animal;
    }
}

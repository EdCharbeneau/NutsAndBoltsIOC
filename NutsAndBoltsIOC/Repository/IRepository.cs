using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NutsAndBoltsIOC.Repository
{
    public interface IRepository<T>
    {
        string GetSomething();
    }
}

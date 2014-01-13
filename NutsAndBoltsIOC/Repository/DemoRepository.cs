using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NutsAndBoltsIOC.Repository
{
    public class DemoRepository<T> : IRepository<T>
    {

        /* IContext will be injected to the repository
         * When GetSomething is called, the Concrete Context will be called and return a message
         * 
         * Responsiblity: to be a middle man between the database and service. Does generalized CRUD.
         */

        private readonly IContext _context;

        public DemoRepository(IContext context)
        {
            _context = context;
        }

        public string GetSomething()
        {
            return _context.GetAllTheThings(string.Format("{0} repository.", typeof(T).Name));
        }
    }
}
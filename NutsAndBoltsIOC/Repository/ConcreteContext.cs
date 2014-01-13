using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NutsAndBoltsIOC.Repository
{
    /*
     * The context of your application could be any resource for example a database
     * 
     * Ex: Database
     * In a real world apllication, this would be an implementation of DbContext
     * IContext would represent an inteface to the implementation of DbContext
     */
    public class ConcreteContext : IContext
    {
        public string GetAllTheThings(string parameter)
        {
            return string.Format("You got all the things from {0}", parameter);
        }
    }
}
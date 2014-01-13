using Autofac; // Autofac reference
using Autofac.Integration.Mvc; // Autofac MVC5 reference
using System.Web.Mvc; 

namespace NutsAndBoltsIOC
{
    public class DependencyResolverConfig
    {
        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            // Register types that are IController
            builder.RegisterControllers(typeof(MvcApplication).Assembly); // RegisterControllers requires Autofac.Integratiion.MVC

            // Register application components here

            // Build container
            var container = builder.Build();

            // Tell MVC to use the AutofacDependencyResolver
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container)); // DependencyResolver requires System.Web.Mvc

        }
    }
}
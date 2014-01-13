using Autofac; // Autofac reference
using Autofac.Integration.Mvc; // Autofac MVC5 reference
using NutsAndBoltsIOC.Repository;
using System.Data.Entity;
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
            
            // InstancePerHttpRequest let's autofac handle when an object is disposed. Useful for disposing connections, and database contexts
            builder.RegisterType<ConcreteContext>().As<IContext>().InstancePerHttpRequest(); 
            builder.RegisterGeneric(typeof(DemoRepository<>)).As(typeof(IRepository<>));
            builder.RegisterType<ApplicationService>().As<IApplicationService>().InstancePerHttpRequest();

            // Build container
            var container = builder.Build();

            // Tell MVC to use the AutofacDependencyResolver
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container)); // DependencyResolver requires System.Web.Mvc

        }
    }
}
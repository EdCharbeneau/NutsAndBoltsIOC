using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NutsAndBoltsIOC.Startup))]
namespace NutsAndBoltsIOC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

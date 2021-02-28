using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UsedCars.Startup))]
namespace UsedCars
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

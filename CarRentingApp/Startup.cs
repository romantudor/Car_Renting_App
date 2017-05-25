using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarRentingApp.Startup))]
namespace CarRentingApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

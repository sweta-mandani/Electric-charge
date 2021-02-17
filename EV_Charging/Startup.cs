using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EV_Charging.Startup))]
namespace EV_Charging
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

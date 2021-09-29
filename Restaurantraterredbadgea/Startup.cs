using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Restaurantraterredbadgea.Startup))]
namespace Restaurantraterredbadgea
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(efcWeb.Startup))]
namespace efcWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

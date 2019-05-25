using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PHocKi.Startup))]
namespace PHocKi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

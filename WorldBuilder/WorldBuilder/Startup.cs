using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WorldBuilder.Startup))]
namespace WorldBuilder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

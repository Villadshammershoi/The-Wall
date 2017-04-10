using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(The_Wall.Startup))]
namespace The_Wall
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

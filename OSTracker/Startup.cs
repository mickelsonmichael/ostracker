using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OSTracker.Startup))]
namespace OSTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

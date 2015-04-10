using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecurityTestInCLass.Startup))]
namespace SecurityTestInCLass
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

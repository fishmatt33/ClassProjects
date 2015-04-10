using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InClassSecurityTest.Startup))]
namespace InClassSecurityTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UrlsAndRouting.Startup))]
namespace UrlsAndRouting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

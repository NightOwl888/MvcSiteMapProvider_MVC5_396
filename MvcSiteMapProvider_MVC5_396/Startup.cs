using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcSiteMapProvider_MVC5_396.Startup))]
namespace MvcSiteMapProvider_MVC5_396
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

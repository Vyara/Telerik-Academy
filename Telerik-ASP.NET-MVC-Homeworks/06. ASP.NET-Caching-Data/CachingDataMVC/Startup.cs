using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CachingDataMVC.Startup))]
namespace CachingDataMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

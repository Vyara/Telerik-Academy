using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PageEvents.Startup))]
namespace PageEvents
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

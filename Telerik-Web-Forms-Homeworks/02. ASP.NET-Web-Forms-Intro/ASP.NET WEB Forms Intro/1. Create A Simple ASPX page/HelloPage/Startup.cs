using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloPage.Startup))]
namespace HelloPage
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

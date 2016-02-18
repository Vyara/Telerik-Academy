using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CatsApp.Web.Startup))]
namespace CatsApp.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

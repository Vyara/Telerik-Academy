using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Chirper.Web.Startup))]
namespace Chirper.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SumMVC.Startup))]
namespace SumMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

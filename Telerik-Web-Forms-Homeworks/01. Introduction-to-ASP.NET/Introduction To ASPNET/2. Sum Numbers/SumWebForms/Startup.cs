using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SumWebForms.Startup))]
namespace SumWebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

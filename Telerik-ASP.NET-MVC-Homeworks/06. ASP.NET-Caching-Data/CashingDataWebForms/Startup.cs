using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CashingDataWebForms.Startup))]
namespace CashingDataWebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HandlerTextToPng.Startup))]
namespace HandlerTextToPng
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

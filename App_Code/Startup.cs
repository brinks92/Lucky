using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lucky.Startup))]
namespace Lucky
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

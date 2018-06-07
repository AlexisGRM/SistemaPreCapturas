using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CapturaPrecontratos.Startup))]
namespace CapturaPrecontratos
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

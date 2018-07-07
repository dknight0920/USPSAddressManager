using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(USPSAddressManagerWeb.Startup))]
namespace USPSAddressManagerWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

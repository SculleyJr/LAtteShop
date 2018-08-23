using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LatteShop.Startup))]
namespace LatteShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

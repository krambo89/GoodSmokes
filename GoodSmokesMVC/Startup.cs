using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoodSmokesMVC.Startup))]
namespace GoodSmokesMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

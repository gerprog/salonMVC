using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(salonMVC.Startup))]
namespace salonMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

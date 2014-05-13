using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusikMVC.Startup))]
namespace MusikMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

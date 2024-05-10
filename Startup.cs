using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dotMVC.Startup))]
namespace dotMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

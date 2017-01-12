using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleAspNetMvcApp.Startup))]
namespace SimpleAspNetMvcApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

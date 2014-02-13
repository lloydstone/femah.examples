using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SomeApplication.Web.Startup))]
namespace SomeApplication.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

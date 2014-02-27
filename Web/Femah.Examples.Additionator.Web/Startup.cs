using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Femah.Examples.Additionator.Web.Startup))]
namespace Femah.Examples.Additionator.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

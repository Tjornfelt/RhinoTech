using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestUrlRoute.Startup))]
namespace TestUrlRoute
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

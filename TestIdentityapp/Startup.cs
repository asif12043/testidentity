using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestIdentityapp.Startup))]
namespace TestIdentityapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

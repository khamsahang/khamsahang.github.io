using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleUser.Startup))]
namespace SimpleUser
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

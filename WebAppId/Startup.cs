using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppId.Startup))]
namespace WebAppId
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

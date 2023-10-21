using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebsiteNoiThatVHL.Startup))]
namespace WebsiteNoiThatVHL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ISASIMVCWebsite.Startup))]
namespace ISASIMVCWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

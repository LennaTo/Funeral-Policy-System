using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FuneralPolicyApp.Startup))]
namespace FuneralPolicyApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

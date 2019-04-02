using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JaisuryaHerbals.Startup))]
namespace JaisuryaHerbals
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

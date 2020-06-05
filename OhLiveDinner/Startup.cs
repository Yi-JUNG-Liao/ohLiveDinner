using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OhLiveDinner.Startup))]
namespace OhLiveDinner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Athena_POC.Startup))]
namespace Athena_POC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

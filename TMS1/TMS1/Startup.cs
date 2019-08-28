using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TMS1.Startup))]
namespace TMS1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

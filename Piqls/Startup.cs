using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Piqls.Startup))]
namespace Piqls
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

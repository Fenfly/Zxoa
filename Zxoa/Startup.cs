using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zxoa.Startup))]
namespace Zxoa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

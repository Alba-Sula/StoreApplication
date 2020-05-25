using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StoreApplication.Startup))]
namespace StoreApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

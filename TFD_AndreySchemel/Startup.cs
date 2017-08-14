using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TFD_AndreySchemel.Startup))]
namespace TFD_AndreySchemel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(movieFan.Startup))]
namespace movieFan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

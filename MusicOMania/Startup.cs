using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicOMania.Startup))]
namespace MusicOMania
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

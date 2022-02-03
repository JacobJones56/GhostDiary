using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GhostDiary.Startup))]
namespace GhostDiary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstProjectGit.Startup))]
namespace FirstProjectGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHubAsp.Startup))]
namespace GitHubAsp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

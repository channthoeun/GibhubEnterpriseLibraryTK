using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GithubEnterpriseLibraryTK.Startup))]
namespace GithubEnterpriseLibraryTK
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

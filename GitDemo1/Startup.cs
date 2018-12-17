using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitDemo1.Startup))]
namespace GitDemo1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(file1.Startup))]
namespace file1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyBootstrapSchool.Startup))]
namespace MyBootstrapSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyTestProject.Startup))]
namespace MyTestProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

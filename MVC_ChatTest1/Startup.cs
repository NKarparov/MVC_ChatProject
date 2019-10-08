using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_ChatTest1.Startup))]
namespace MVC_ChatTest1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(admEidTarea2.Startup))]
namespace admEidTarea2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

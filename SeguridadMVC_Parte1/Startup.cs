using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SeguridadMVC_Parte1.Startup))]
namespace SeguridadMVC_Parte1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

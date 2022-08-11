using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1_Controle_Contas_Web.Startup))]
namespace _1_Controle_Contas_Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

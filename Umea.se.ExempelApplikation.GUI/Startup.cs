using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Umea.se.ExempelApplikation.GUI.Startup))]
namespace Umea.se.ExempelApplikation.GUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

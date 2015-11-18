using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pos.UI.WebMvc.Pos.Startup))]
namespace Pos.UI.WebMvc.Pos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HFEP_Oversights.Startup))]
namespace HFEP_Oversights
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MedLab.Web.Startup))]
namespace MedLab.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TH_LTWebLab02_03.Startup))]
namespace TH_LTWebLab02_03
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
